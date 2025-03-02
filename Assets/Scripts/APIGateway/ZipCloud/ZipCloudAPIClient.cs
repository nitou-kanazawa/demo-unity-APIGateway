using System;
using Cysharp.Threading.Tasks;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using Unity.Plastic.Newtonsoft.Json;

namespace APIGateway.ZipCode {

    public sealed class ZipCloudAPIClient {

        private const string BaseUrl = "https://zipcloud.ibsnet.co.jp/api/search?zipcode=";

        /// <summary>
        /// óXï÷î‘çÜÇ©ÇÁèZèäÇåüçıÇ∑ÇÈÅD
        /// </summary>
        public static async UniTask<ZipCloudResponse> GetAddressFromZipAsync(string zipcode) {
            
            var url = $"{BaseUrl}{zipcode}";

            using (var request = UnityWebRequest.Get(url)) {
                
                await request.SendWebRequest();

                if (request.result == UnityWebRequest.Result.Success) {
                    string json = request.downloadHandler.text;
                    return JsonUtility.FromJson<ZipCloudResponse>(json);
                } 
                else {
                    Debug.LogError($"ZipCloud API Error: {request.error}");
                    return null;
                }
            }
        }
    }
}
