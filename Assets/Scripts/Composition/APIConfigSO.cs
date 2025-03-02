using UnityEngine;


namespace Composition {

    [CreateAssetMenu(menuName = "Scriptable Objects/APIKey")]
    public class APIConfigSO : ScriptableObject {
        
        public string weatherApiKey;

        public string gitHub;
    }
}
