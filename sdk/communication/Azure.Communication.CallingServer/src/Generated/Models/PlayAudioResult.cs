// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> The response payload for play audio operation. </summary>
    public partial class PlayAudioResult
    {
        /// <summary> Initializes a new instance of PlayAudioResult. </summary>
        /// <param name="status"> The status of the operation. </param>
        internal PlayAudioResult(OperationStatus status)
        {
            Status = status;
        }

        /// <summary> Initializes a new instance of PlayAudioResult. </summary>
        /// <param name="operationId"> The operation id. </param>
        /// <param name="status"> The status of the operation. </param>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <param name="resultInfo"> The result info for the operation. </param>
        internal PlayAudioResult(string operationId, OperationStatus status, string operationContext, ResultInfo resultInfo)
        {
            OperationId = operationId;
            Status = status;
            OperationContext = operationContext;
            ResultInfo = resultInfo;
        }

        /// <summary> The operation id. </summary>
        public string OperationId { get; }
        /// <summary> The status of the operation. </summary>
        public OperationStatus Status { get; }
        /// <summary> The operation context provided by client. </summary>
        public string OperationContext { get; }
        /// <summary> The result info for the operation. </summary>
        public ResultInfo ResultInfo { get; }
    }
}
