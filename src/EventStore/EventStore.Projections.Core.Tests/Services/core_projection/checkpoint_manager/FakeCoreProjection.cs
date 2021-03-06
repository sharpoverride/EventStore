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

using System.Collections.Generic;
using EventStore.Projections.Core.Messages;

namespace EventStore.Projections.Core.Tests.Services.core_projection.checkpoint_manager
{
    public class FakeCoreProjection : ICoreProjection
    {
        public readonly List<ProjectionSubscriptionMessage.CommittedEventReceived> _committedEventReceivedMessages =
            new List<ProjectionSubscriptionMessage.CommittedEventReceived>();

        public readonly List<ProjectionSubscriptionMessage.CheckpointSuggested> _checkpointSuggestedMessages =
            new List<ProjectionSubscriptionMessage.CheckpointSuggested>();

        public readonly List<CoreProjectionProcessingMessage.CheckpointCompleted> _checkpointCompletedMessages =
            new List<CoreProjectionProcessingMessage.CheckpointCompleted>();

        public readonly List<CoreProjectionProcessingMessage.PauseRequested> _pauseRequestedMessages =
            new List<CoreProjectionProcessingMessage.PauseRequested>();

        public readonly List<CoreProjectionProcessingMessage.CheckpointLoaded> _checkpointLoadedMessages =
            new List<CoreProjectionProcessingMessage.CheckpointLoaded>();

        public readonly List<ProjectionSubscriptionMessage.ProgressChanged> _progresschangedMessages =
            new List<ProjectionSubscriptionMessage.ProgressChanged>();

        public void Handle(ProjectionSubscriptionMessage.CommittedEventReceived message)
        {
            _committedEventReceivedMessages.Add(message);
        }

        public void Handle(ProjectionSubscriptionMessage.CheckpointSuggested message)
        {
            _checkpointSuggestedMessages.Add(message);
        }

        public void Handle(CoreProjectionProcessingMessage.CheckpointCompleted message)
        {
            _checkpointCompletedMessages.Add(message);
        }

        public void Handle(CoreProjectionProcessingMessage.PauseRequested message)
        {
            _pauseRequestedMessages.Add(message);
        }

        public void Handle(CoreProjectionProcessingMessage.CheckpointLoaded message)
        {
            _checkpointLoadedMessages.Add(message);
        }

        public void Handle(ProjectionSubscriptionMessage.ProgressChanged message)
        {
            _progresschangedMessages.Add(message);
        }

        public void Handle(CoreProjectionProcessingMessage.RestartRequested message)
        {
            throw new System.NotImplementedException();
        }
    }
}
