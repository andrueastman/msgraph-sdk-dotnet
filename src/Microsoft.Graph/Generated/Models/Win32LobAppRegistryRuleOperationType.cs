// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>A list of possible operations for rules used to make determinations about an application based on registry keys or values. Unless noted, the values can be used with either detection or requirement rules.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.18.0")]
    public enum Win32LobAppRegistryRuleOperationType
    {
        /// <summary>Default. Indicates that the rule does not have the operation type configured.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Indicates that the rule evaluates whether the specified registry key or value exists.</summary>
        [EnumMember(Value = "exists")]
        Exists,
        /// <summary>Indicates that the rule evaluates whether the specified registry key or value does not exist. It is the functional inverse of an equivalent rule that uses operation type `exists`.</summary>
        [EnumMember(Value = "doesNotExist")]
        DoesNotExist,
        /// <summary>Indicates that the rule compares the value read at the given registry value against a provided comparison value by string comparison.</summary>
        [EnumMember(Value = "string")]
        String,
        /// <summary>Indicates that the rule compares the value read at the given registry value against a provided comparison value by integer comparison.</summary>
        [EnumMember(Value = "integer")]
        Integer,
        /// <summary>Indicates that the rule compares the value read at the given registry value against a provided comparison value via version semantics (both operand values will be parsed as versions and directly compared). If the value read at the given registry value is not discovered to be in version-compatible format, a string comparison will be used instead.</summary>
        [EnumMember(Value = "version")]
        Version,
    }
}
