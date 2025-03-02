using System;

namespace APIGateway.ZipCode {

    [Serializable]
    public record ZipCloudResult {

        /// <summary>
        /// —X•Ö”Ô†D
        /// </summary>
        public string zipcode;

        /// <summary>
        /// “s“¹•{Œ§D
        /// </summary>
        public string address1;

        /// <summary>
        /// s‹æ’¬‘ºD
        /// </summary>
        public string address2;

        /// <summary>
        /// ’¬ˆæD
        /// </summary>
        public string address3;

        public string kana1;
        public string kana2;
        public string kana3;
    }


    [Serializable]
    public record ZipCloudResponse {
        public int status;
        public string message;
        public ZipCloudResult[] results;
    }
}
