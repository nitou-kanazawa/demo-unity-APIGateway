using System;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace APIGateway.GitHub {

    public sealed class GitHubAPIClient {

        private const string BaseUrl = "https://api.github.com/repos/";

        public async UniTask<GitHubRepository> GetRepositoryInfoAsync(string owner, string repo) {

            string url = $"{BaseUrl}{owner}/{repo}";

            using (var request = UnityWebRequest.Get(url)) {

                // GitHub APIのUser-Agent要件を満たすためのヘッダー追加
                request.SetRequestHeader("User-Agent", "Unity-GitHub-Client");

                // 
                await request.SendWebRequest();
                if (request.result is UnityWebRequest.Result.Success) {
                    string json = request.downloadHandler.text;
                    return JsonUtility.FromJson<GitHubRepository>(json);
                } else {
                    Debug.LogError($"GitHub API Error: {request.error}");
                    return null;
                }
            }
        }
    }
}
