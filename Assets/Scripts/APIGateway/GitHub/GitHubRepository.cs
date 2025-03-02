using System;
using UnityEngine;

namespace APIGateway.GitHub {
    
    [Serializable]
    public class GitHubRepository {

        public string name;
        public string full_name;
        public string description;
        public int stargazers_count;
        public int forks_count;
        public string html_url;
        public string updated_at;
    }
}
