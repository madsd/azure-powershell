// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support
{

    /// <summary>The type of resource, for instance Microsoft.Kusto/Clusters/databases.</summary>
    public partial struct Type :
        System.IEquatable<Type>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Type MicrosoftKustoClustersAttachedDatabaseConfigurations = @"Microsoft.Kusto/Clusters/attachedDatabaseConfigurations";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Type MicrosoftKustoClustersDatabases = @"Microsoft.Kusto/Clusters/databases";

        /// <summary>the value for an instance of the <see cref="Type" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to Type</summary>
        /// <param name="value">the value to convert to an instance of <see cref="Type" />.</param>
        internal static object CreateFrom(object value)
        {
            return new Type(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type Type</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Type e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type Type (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is Type && Equals((Type)obj);
        }

        /// <summary>Returns hashCode for enum Type</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for Type</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Creates an instance of the <see cref="Type" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private Type(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to Type</summary>
        /// <param name="value">the value to convert to an instance of <see cref="Type" />.</param>

        public static implicit operator Type(string value)
        {
            return new Type(value);
        }

        /// <summary>Implicit operator to convert Type to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="Type" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Type e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum Type</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Type e1, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Type e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum Type</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Type e1, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.Type e2)
        {
            return e2.Equals(e1);
        }
    }
}