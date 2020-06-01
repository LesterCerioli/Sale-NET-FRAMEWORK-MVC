using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale_DOTNET.Domain.Entities
{
    public abstract class Entity
    {
        private List<string> _validationMessage { get; set; }
        private List<string> validationMessage
        {
            get { return _validationMessage ?? (_validationMessage = new List<string>()); }
        }
        public void ClearValidationMessage()
        {
            validationMessage.Clear();
        }
        protected void AddCritical(string message)
        {
            validationMessage.Add(message);
        }
        public string GetValidationMessage()
        {
            return string.Join(".", validationMessage);
        }
        public abstract void Validate();
        public bool EhValid
        {
            get { return !validationMessage.Any(); }
        }
    }
}
