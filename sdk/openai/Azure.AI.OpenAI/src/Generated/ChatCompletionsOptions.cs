// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// The configuration information for a chat completions request.
    /// Completions support a wide variety of tasks and generate text that continues from or "completes"
    /// provided prompt data.
    /// </summary>
    public partial class ChatCompletionsOptions
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ChatCompletionsOptions"/>. </summary>
        /// <param name="messages">
        /// The collection of context messages associated with this chat completions request.
        /// Typical usage begins with a chat message for the System role that provides instructions for
        /// the behavior of the assistant, followed by alternating messages between the User and
        /// Assistant roles.
        /// </param>
        /// <param name="functions"> A list of functions the model may generate JSON inputs for. </param>
        /// <param name="functionCall">
        /// Controls how the model responds to function calls. "none" means the model does not call a function,
        /// and responds to the end-user. "auto" means the model can pick between an end-user or calling a function.
        ///  Specifying a particular function via `{"name": "my_function"}` forces the model to call that function.
        ///  "none" is the default when no functions are present. "auto" is the default if functions are present.
        /// </param>
        /// <param name="maxTokens"> The maximum number of tokens to generate. </param>
        /// <param name="temperature">
        /// The sampling temperature to use that controls the apparent creativity of generated completions.
        /// Higher values will make output more random while lower values will make results more focused
        /// and deterministic.
        /// It is not recommended to modify temperature and top_p for the same completions request as the
        /// interaction of these two settings is difficult to predict.
        /// </param>
        /// <param name="nucleusSamplingFactor">
        /// An alternative to sampling with temperature called nucleus sampling. This value causes the
        /// model to consider the results of tokens with the provided probability mass. As an example, a
        /// value of 0.15 will cause only the tokens comprising the top 15% of probability mass to be
        /// considered.
        /// It is not recommended to modify temperature and top_p for the same completions request as the
        /// interaction of these two settings is difficult to predict.
        /// </param>
        /// <param name="tokenSelectionBiases">
        /// A map between GPT token IDs and bias scores that influences the probability of specific tokens
        /// appearing in a completions response. Token IDs are computed via external tokenizer tools, while
        /// bias scores reside in the range of -100 to 100 with minimum and maximum values corresponding to
        /// a full ban or exclusive selection of a token, respectively. The exact behavior of a given bias
        /// score varies by model.
        /// </param>
        /// <param name="user">
        /// An identifier for the caller or end user of the operation. This may be used for tracking
        /// or rate-limiting purposes.
        /// </param>
        /// <param name="choiceCount">
        /// The number of chat completions choices that should be generated for a chat completions
        /// response.
        /// Because this setting can generate many completions, it may quickly consume your token quota.
        /// Use carefully and ensure reasonable settings for max_tokens and stop.
        /// </param>
        /// <param name="stopSequences"> A collection of textual sequences that will end completions generation. </param>
        /// <param name="presencePenalty">
        /// A value that influences the probability of generated tokens appearing based on their existing
        /// presence in generated text.
        /// Positive values will make tokens less likely to appear when they already exist and increase the
        /// model's likelihood to output new topics.
        /// </param>
        /// <param name="frequencyPenalty">
        /// A value that influences the probability of generated tokens appearing based on their cumulative
        /// frequency in generated text.
        /// Positive values will make tokens less likely to appear as their frequency increases and
        /// decrease the likelihood of the model repeating the same statements verbatim.
        /// </param>
        /// <param name="internalShouldStreamResponse"> A value indicating whether chat completions should be streamed for this request. </param>
        /// <param name="deploymentName">
        /// The model name to provide as part of this completions request.
        /// Not applicable to Azure OpenAI, where deployment information should be included in the Azure
        /// resource URI that's connected to.
        /// </param>
        /// <param name="internalAzureExtensionsDataSources">
        ///   The configuration entries for Azure OpenAI chat extensions that use them.
        ///   This additional specification is only compatible with Azure OpenAI.
        /// </param>
        /// <param name="enhancements"> If provided, the configuration options for available Azure OpenAI chat enhancements. </param>
        /// <param name="seed">
        /// If specified, the system will make a best effort to sample deterministically such that repeated requests with the
        /// same seed and parameters should return the same result. Determinism is not guaranteed, and you should refer to the
        /// system_fingerprint response parameter to monitor changes in the backend."
        /// </param>
        /// <param name="enableLogProbabilities"> Whether to return log probabilities of the output tokens or not. If true, returns the log probabilities of each output token returned in the `content` of `message`. This option is currently not available on the `gpt-4-vision-preview` model. </param>
        /// <param name="logProbabilitiesPerToken"> An integer between 0 and 5 specifying the number of most likely tokens to return at each token position, each with an associated log probability. `logprobs` must be set to `true` if this parameter is used. </param>
        /// <param name="responseFormat"> An object specifying the format that the model must output. Used to enable JSON mode. </param>
        /// <param name="tools"> The available tool definitions that the chat completions request can use, including caller-defined functions. </param>
        /// <param name="internalSuppressedToolChoice"> If specified, the model will configure which of the provided tools it can use for the chat completions response. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChatCompletionsOptions(IList<ChatRequestMessage> messages, IList<FunctionDefinition> functions, FunctionDefinition functionCall, int? maxTokens, float? temperature, float? nucleusSamplingFactor, IDictionary<int, int> tokenSelectionBiases, string user, int? choiceCount, IList<string> stopSequences, float? presencePenalty, float? frequencyPenalty, bool? internalShouldStreamResponse, string deploymentName, IList<AzureChatExtensionConfiguration> internalAzureExtensionsDataSources, AzureChatEnhancementConfiguration enhancements, long? seed, bool? enableLogProbabilities, int? logProbabilitiesPerToken, ChatCompletionsResponseFormat responseFormat, IList<ChatCompletionsToolDefinition> tools, BinaryData internalSuppressedToolChoice, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Messages = messages;
            Functions = functions;
            FunctionCall = functionCall;
            MaxTokens = maxTokens;
            Temperature = temperature;
            NucleusSamplingFactor = nucleusSamplingFactor;
            TokenSelectionBiases = tokenSelectionBiases;
            User = user;
            ChoiceCount = choiceCount;
            StopSequences = stopSequences;
            PresencePenalty = presencePenalty;
            FrequencyPenalty = frequencyPenalty;
            InternalShouldStreamResponse = internalShouldStreamResponse;
            DeploymentName = deploymentName;
            InternalAzureExtensionsDataSources = internalAzureExtensionsDataSources;
            Enhancements = enhancements;
            Seed = seed;
            EnableLogProbabilities = enableLogProbabilities;
            LogProbabilitiesPerToken = logProbabilitiesPerToken;
            ResponseFormat = responseFormat;
            Tools = tools;
            InternalSuppressedToolChoice = internalSuppressedToolChoice;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The collection of context messages associated with this chat completions request.
        /// Typical usage begins with a chat message for the System role that provides instructions for
        /// the behavior of the assistant, followed by alternating messages between the User and
        /// Assistant roles.
        /// Please note <see cref="ChatRequestMessage"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ChatRequestSystemMessage"/>, <see cref="ChatRequestUserMessage"/>, <see cref="ChatRequestAssistantMessage"/>, <see cref="ChatRequestToolMessage"/> and <see cref="ChatRequestFunctionMessage"/>.
        /// </summary>
        public IList<ChatRequestMessage> Messages { get; }
        /// <summary>
        /// An identifier for the caller or end user of the operation. This may be used for tracking
        /// or rate-limiting purposes.
        /// </summary>
        public string User { get; set; }
        /// <summary>
        /// If specified, the system will make a best effort to sample deterministically such that repeated requests with the
        /// same seed and parameters should return the same result. Determinism is not guaranteed, and you should refer to the
        /// system_fingerprint response parameter to monitor changes in the backend."
        /// </summary>
        public long? Seed { get; set; }
        /// <summary> Whether to return log probabilities of the output tokens or not. If true, returns the log probabilities of each output token returned in the `content` of `message`. This option is currently not available on the `gpt-4-vision-preview` model. </summary>
        public bool? EnableLogProbabilities { get; set; }
        /// <summary> An integer between 0 and 5 specifying the number of most likely tokens to return at each token position, each with an associated log probability. `logprobs` must be set to `true` if this parameter is used. </summary>
        public int? LogProbabilitiesPerToken { get; set; }
        /// <summary>
        /// An object specifying the format that the model must output. Used to enable JSON mode.
        /// Please note <see cref="ChatCompletionsResponseFormat"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes..
        /// </summary>
        public ChatCompletionsResponseFormat ResponseFormat { get; set; }
        /// <summary>
        /// The available tool definitions that the chat completions request can use, including caller-defined functions.
        /// Please note <see cref="ChatCompletionsToolDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ChatCompletionsFunctionToolDefinition"/>.
        /// </summary>
        public IList<ChatCompletionsToolDefinition> Tools { get; }
    }
}
