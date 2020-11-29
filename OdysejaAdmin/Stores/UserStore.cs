using System;

namespace OdysejaAdmin.Stores
{
    public class UserStoreData
    {
        public string JSESSIONID { get; set; }
        public bool IsAuth { get; set; }

        public UserStoreData()
        {
        }
    }
    
    public class UserStore
    {
        private UserStoreData _state;

        public UserStoreData GetState() => _state;

        public UserStore()
        {
            _state = new UserStoreData();
        }

        public void SetAuth(bool auth)
        {
            _state.IsAuth = auth;
            BroadcastStateChange();
        }

        public void SetCookie(string jsessionid) => _state.JSESSIONID = jsessionid;
        public string GetCookie() => _state.JSESSIONID;
        
        #region observer pattern
        private Action _listeners;
        
        public void AddStateListeners(Action listener) => _listeners += listener;
        
        public void RemoveStateListeners(Action listener) => _listeners -= listener;
        
        public void BroadcastStateChange() => _listeners.Invoke();
        #endregion
    }
}