using System;

namespace APIGateway.ZipCode {

    [Serializable]
    public record ZipCloudResult {

        /// <summary>
        /// 郵便番号．
        /// </summary>
        public string zipcode;

        /// <summary>
        /// 都道府県．
        /// </summary>
        public string address1;

        /// <summary>
        /// 市区町村．
        /// </summary>
        public string address2;

        /// <summary>
        /// 町域．
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
