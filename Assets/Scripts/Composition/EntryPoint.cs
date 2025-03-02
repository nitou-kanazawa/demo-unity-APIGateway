using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

using APIGateway.GitHub;
using APIGateway.ZipCode;

namespace Composition {

    public class EntryPoint : MonoBehaviour {

        [SerializeField] APIConfigSO _config;


        private async void Start() {
            string testZipcode = "1000001"; // “Œ‹“sç‘ã“c‹æç‘ã“c

            ZipCloudResponse response = await ZipCloudAPIClient.GetAddressFromZipAsync(testZipcode);

            if (response != null && response.results != null && response.results.Length > 0) {
                var result = response.results[0];
                Debug.Log($"—X•Ö”Ô†: {result.zipcode}");
                Debug.Log($"ZŠ: {result.address1} {result.address2} {result.address3}");
            } else {
                Debug.LogError("ZŠî•ñ‚Ìæ“¾‚É¸”s‚µ‚Ü‚µ‚½B");
            }
        }


        //private async void Start() {
        //    var client = new GitHubAPIClient();

        //    string owner = "torvalds";  // —á: Linus Torvalds
        //    string repo = "linux";      // —á: LinuxƒJ[ƒlƒ‹

        //    var repository = await client.GetRepositoryInfoAsync(owner, repo);

        //    if (repository != null) {
        //        Debug.Log($"Repository: {repository.full_name}");
        //        Debug.Log($"Description: {repository.description}");
        //        Debug.Log($"Stars: {repository.stargazers_count}");
        //        Debug.Log($"Forks: {repository.forks_count}");
        //        Debug.Log($"URL: {repository.html_url}");
        //    } else {
        //        Debug.LogError("Failed to fetch repository information.");
        //    }
        //}



        private const string BaseUrl = "https://ja.wikipedia.org/api/rest_v1";

        //async void Start() {

        //    var key = "—I–Ø•É";
        //    var request = UnityWebRequest.Get($"{BaseUrl}/page/summary/{key}");

        //    await request.SendWebRequest();
        //    if(request.result is UnityWebRequest.Result.Success) {
        //        Debug.Log(request.downloadHandler.text);
        //    } else {
        //        Debug.LogWarning(request.error);
        //    }

        //}

    }

}