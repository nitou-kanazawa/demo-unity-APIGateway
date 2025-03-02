using Cysharp.Threading.Tasks;
using System;
using UnityEngine;
using UnityEngine.Networking;

// [REF]
//  zenn: UnityWebRequest��OpenAI��ChatCompletionsAPI��POST���� https://zenn.dev/wappaboy/scraps/202860fb1bb5eb

namespace APIGateway.OpenAI {

    public sealed class ChatGPTService {

        private readonly string _apiKey;

        public ChatGPTService(string apiKey) {
            _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
        }



		/*
		async UniTask<string> GetGPTResponse(ChatMessage[] message, int tryCount = 1) {
			try {
				string url = "https://api.openai.com/v1/chat/completions";
				ChatBody chatBody = new ChatBody {
					model = model,
					messages = message,
					max_tokens = max_tokens,
					temperature = temperature,
					top_p = top_p,
					frequency_penalty = frequency_penalty,
					presence_penalty = presences_penalty
				};
				string myJson = JsonUtility.ToJson(chatBody);
				byte[] jsonToSend = new System.Text.UTF8Encoding().GetBytes(myJson);

				using UnityWebRequest www = new UnityWebRequest(url, UnityWebRequest.kHttpVerbPOST);
				www.uploadHandler = new UploadHandlerRaw(jsonToSend);
				www.downloadHandler = new DownloadHandlerBuffer();
				www.SetRequestHeader("Authorization", "Bearer " + _apiKey);
				www.SetRequestHeader("Content-Type", "application/json");

				await www.SendWebRequest().ToUniTask();
				var response = www.downloadHandler.text;
				Debug.Log(response);
				//JSON�`����response��Body�N���X�ɕϊ�
				var responseJson = JsonUtility.FromJson<ChatResponse>(response);
				//Body�N���X�̒���messages�̒���content���擾
				var output = responseJson.choices[0].message.content;
				return output;
			} catch (Exception e) {
				//�G���[���o����AtryCount�񎸔s����܂ł�����x���s
				Debug.LogError($"�y{tryCount}��ځzChatGPT�̃G���[:{e}");
				var newCount = tryCount + 1;
				if (newCount > 10) {
					throw new Exception("ChatGPT�̃G���[��10�񑱂������߁A�����𒆒f���܂���.");
				}
				return await GetGPTResponse(message, newCount);
			}
		}
		*/


	}
}
