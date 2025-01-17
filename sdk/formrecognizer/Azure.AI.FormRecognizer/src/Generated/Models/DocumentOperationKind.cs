// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Type of operation. </summary>
    public readonly partial struct DocumentOperationKind : IEquatable<DocumentOperationKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DocumentOperationKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DocumentOperationKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DocumentModelBuildValue = "documentModelBuild";
        private const string DocumentModelComposeValue = "documentModelCompose";
        private const string DocumentModelCopyToValue = "documentModelCopyTo";
        private const string DocumentClassifierBuildValue = "documentClassifierBuild";

        /// <summary> Build a new custom document model. </summary>
        public static DocumentOperationKind DocumentModelBuild { get; } = new DocumentOperationKind(DocumentModelBuildValue);
        /// <summary> Compose a new custom document model from existing models. </summary>
        public static DocumentOperationKind DocumentModelCompose { get; } = new DocumentOperationKind(DocumentModelComposeValue);
        /// <summary> Copy an existing document model to potentially a different resource, region, or subscription. </summary>
        public static DocumentOperationKind DocumentModelCopyTo { get; } = new DocumentOperationKind(DocumentModelCopyToValue);
        /// <summary> Determines if two <see cref="DocumentOperationKind"/> values are the same. </summary>
        public static bool operator ==(DocumentOperationKind left, DocumentOperationKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DocumentOperationKind"/> values are not the same. </summary>
        public static bool operator !=(DocumentOperationKind left, DocumentOperationKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DocumentOperationKind"/>. </summary>
        public static implicit operator DocumentOperationKind(string value) => new DocumentOperationKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DocumentOperationKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DocumentOperationKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
