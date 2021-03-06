// Copyright (c) 2012, Event Store LLP
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are
// met:
// 
// Redistributions of source code must retain the above copyright notice,
// this list of conditions and the following disclaimer.
// Redistributions in binary form must reproduce the above copyright
// notice, this list of conditions and the following disclaimer in the
// documentation and/or other materials provided with the distribution.
// Neither the name of the Event Store LLP nor the names of its
// contributors may be used to endorse or promote products derived from
// this software without specific prior written permission
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
// HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
// 

using System;
using EventStore.Core.Messaging;
using EventStore.Projections.Core.Services.Processing;

namespace EventStore.Projections.Core.Messages
{
    public static class CoreProjectionProcessingMessage
    {
        public class CheckpointLoaded : Message
        {
            private readonly Guid _correlationId;
            private readonly CheckpointTag _checkpointTag;
            private readonly string _checkpointData;

            public CheckpointLoaded(Guid correlationId, CheckpointTag checkpointTag, string checkpointData)
            {
                _correlationId = correlationId;
                _checkpointTag = checkpointTag;
                _checkpointData = checkpointData;
            }

            public Guid CorrelationId
            {
                get { return _correlationId; }
            }

            public CheckpointTag CheckpointTag
            {
                get { return _checkpointTag; }
            }

            public string CheckpointData
            {
                get { return _checkpointData; }
            }
        }

        public class ReadyForCheckpoint : Message
        {
            private readonly object _sender;

            public ReadyForCheckpoint(object sender)
            {
                _sender = sender;
            }

            public object Sender
            {
                get { return _sender; }
            }
        }

        public class CheckpointCompleted : Message
        {
            private readonly CheckpointTag _checkpointTag;

            public CheckpointCompleted(CheckpointTag checkpointTag)
            {
                _checkpointTag = checkpointTag;
            }

            public CheckpointTag CheckpointTag
            {
                get { return _checkpointTag; }
            }
        }

        public class PauseRequested : Message
        {
        }

        public class RestartRequested : Message
        {
            private readonly string _reason;

            public RestartRequested(string reason)
            {
                _reason = reason;
            }

            public string Reason
            {
                get { return _reason; }
            }
        }
    }
}
