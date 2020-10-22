// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Chat
{
    /// <summary> The ChatThread. </summary>
    internal partial class ChatThreadInternal
    {
        /// <summary> Initializes a new instance of ChatThreadInternal. </summary>
        internal ChatThreadInternal()
        {
            Members = new ChangeTrackingList<ChatThreadMemberInternal>();
        }

        /// <summary> Initializes a new instance of ChatThreadInternal. </summary>
        /// <param name="id"> Chat thread id. </param>
        /// <param name="topic"> Chat thread topic. </param>
        /// <param name="createdOn"> The timestamp when the chat thread was created. The timestamp is in ISO8601 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="createdBy"> Id of the chat thread owner. </param>
        /// <param name="members"> Chat thread members. </param>
        internal ChatThreadInternal(string id, string topic, DateTimeOffset? createdOn, string createdBy, IReadOnlyList<ChatThreadMemberInternal> members)
        {
            Id = id;
            Topic = topic;
            CreatedOn = createdOn;
            CreatedBy = createdBy;
            Members = members;
        }

        /// <summary> Chat thread id. </summary>
        public string Id { get; }
        /// <summary> Chat thread topic. </summary>
        public string Topic { get; }
        /// <summary> The timestamp when the chat thread was created. The timestamp is in ISO8601 format: `yyyy-MM-ddTHH:mm:ssZ`. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Id of the chat thread owner. </summary>
        public string CreatedBy { get; }
        /// <summary> Chat thread members. </summary>
        public IReadOnlyList<ChatThreadMemberInternal> Members { get; }
    }
}