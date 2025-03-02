using System;

namespace APIGateway.OpenAI {

    [Serializable]
    public class ChatResponse {
        public string id;
        public string obj;
        public int created;
        public string model;
        public ChatUsage usage;
        public ChatChoice[] choices;
    }

}
