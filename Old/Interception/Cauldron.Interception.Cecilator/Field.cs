﻿using Mono.Cecil;
using Mono.Cecil.Cil;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Cauldron.Interception.Cecilator
{
    public class Field : CecilatorBase, IEquatable<Field>
    {
        [EditorBrowsable(EditorBrowsableState.Never), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal readonly FieldDefinition fieldDef;

        [EditorBrowsable(EditorBrowsableState.Never), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal readonly FieldReference fieldRef;

        [EditorBrowsable(EditorBrowsableState.Never), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal readonly BuilderType type;

        internal Field(BuilderType type, FieldDefinition field) : base(type)
        {
            this.fieldDef = field;
            this.fieldRef = field.CreateFieldReference();
            this.type = type;
        }

        internal Field(BuilderType type, FieldDefinition fieldDefinition, FieldReference fieldReference) : base(type)
        {
            this.fieldDef = fieldDefinition;
            this.fieldRef = fieldReference;
            this.type = type;
        }

        public BuilderCustomAttributeCollection CustomAttributes { get { return new BuilderCustomAttributeCollection(this.type.Builder, this.fieldDef); } }

        public BuilderType DeclaringType { get { return this.type; } }

        public BuilderType FieldType { get { return new BuilderType(this.type, this.fieldRef.FieldType); } }

        public bool IsPrivate { get { return this.fieldDef.IsPrivate; } }

        public bool IsPublic { get { return this.fieldDef.IsPublic; } }

        public bool IsStatic { get { return this.fieldDef.IsStatic; } }

        public Modifiers Modifiers
        {
            get
            {
                Modifiers modifiers = 0;

                if (this.fieldDef.Attributes.HasFlag(FieldAttributes.Private)) modifiers |= Modifiers.Private;
                if (this.fieldDef.Attributes.HasFlag(FieldAttributes.Static)) modifiers |= Modifiers.Static;
                if (this.fieldDef.Attributes.HasFlag(FieldAttributes.Public)) modifiers |= Modifiers.Public;

                return modifiers;
            }
        }

        public string Name { get { return this.fieldDef.Name; } }

        public IEnumerable<FieldUsage> FindUsages()
        {
            var result = this.fieldDef
                .DeclaringType
                .Methods.Concat(this.fieldDef.DeclaringType.GetNestedTypes().SelectMany(x => x.Resolve().Methods))
                .Where(x => x.Body != null)
                .SelectMany(x => this.GetFieldUsage(new Method(new BuilderType(this.type.Builder, x.DeclaringType), x)));

            if (!this.IsPrivate)
                return result.Concat(this.type.Builder.GetTypes().SelectMany(x => x.Methods).SelectMany(x => this.GetFieldUsage(x)));

            return result;
        }

        public void Remove() => this.type.typeDefinition.Fields.Remove(this.fieldDef);

        private IEnumerable<FieldUsage> GetFieldUsage(Method method)
        {
            for (int i = 0; i < method.methodDefinition.Body.Instructions.Count; i++)
            {
                var instruction = method.methodDefinition.Body.Instructions[i];
                if ((instruction.OpCode == OpCodes.Ldsfld ||
                    instruction.OpCode == OpCodes.Ldflda ||
                    instruction.OpCode == OpCodes.Ldsflda ||
                    instruction.OpCode == OpCodes.Ldfld ||
                    instruction.OpCode == OpCodes.Stsfld ||
                    instruction.OpCode == OpCodes.Stfld) &&
                    (instruction.Operand as FieldDefinition ?? instruction.Operand as FieldReference).FullName == this.fieldRef.FullName)
                    yield return new FieldUsage(this, method, instruction);
            }
        }

        #region Equitable stuff

        public static implicit operator string(Field value) => value.ToString();

        public static bool operator !=(Field a, Field b) => !(a == b);

        public static bool operator ==(Field a, Field b)
        {
            if (object.Equals(a, null) && object.Equals(b, null))
                return true;

            if (object.Equals(a, null))
                return false;

            return a.Equals(b);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            if (object.Equals(obj, null))
                return false;

            if (object.ReferenceEquals(obj, this))
                return true;

            if (obj is Field)
                return this.Equals(obj as Field);

            if (obj is FieldDefinition)
                return this.fieldDef == obj as FieldDefinition;

            if (obj is FieldReference)
                return this.fieldRef == obj as FieldReference;

            return false;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool Equals(Field other)
        {
            if (object.Equals(other, null))
                return false;

            if (object.ReferenceEquals(other, this))
                return true;

            return this.fieldDef == other.fieldDef;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => this.fieldDef.GetHashCode();

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => this.fieldRef.FullName;

        #endregion Equitable stuff
    }
}