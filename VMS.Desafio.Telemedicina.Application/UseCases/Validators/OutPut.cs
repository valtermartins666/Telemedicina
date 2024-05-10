using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.Desafio.Telemedicina.Application.UseCases.Validators
{
    public class OutPut<T> where T : notnull 
    {
        private List<string> _messages;
        private List<string> _errorMessages;
        protected T _result;
        public IReadOnlyCollection<string> ErrorMessages => GetMessages(_errorMessages);
        public bool IsValid { get; protected set; }
        public IReadOnlyCollection<string> Messages => GetMessages(_messages);

        public OutPut(bool isValid = true)
        {
            IsValid = isValid;
        }
        public OutPut(T result)
        {
            IsValid = true;
            AddResult(result);            
        }

        private static IReadOnlyCollection<string> GetMessages(List<string> messages)
        {
            if (messages == null)
            {
                return (IReadOnlyCollection<string>)(object)Array.Empty<string>();
            }
            return messages.AsReadOnly();
        }

        public void AddResult(T result)
        {
            if(result == null)
            {
                throw new Exception("Result object is null, please verify.");
            }
            _result = result;
        }
        public void AddMessage(string message)
        {
            AddMessages(message);
        }
        public void AddMessages(params string[] messages)
        {
            CreateMessagesWhenThereIsNone();
            foreach(string text in messages)
            {
                VerifyMessage(text);
                _messages.Add(text);
            }
        }
        public void AddErrorMessage(string message)
        {
            AddErrorMessages(message);
        }
        public void AddErrorMessages(params string[] messages)
        {
            CreateErrorMessagesWhenThereIsNone();
            foreach (string text in messages)
            {
                VerifyErrorMessage(text);
                _errorMessages.Add(text);
            }
            VerifyValidity();
        }

        private void CreateErrorMessagesWhenThereIsNone()
        {
            if(_errorMessages == null)
            {
                _errorMessages = new List<string>();
            }
        }

        private void CreateMessagesWhenThereIsNone()
        {
            if (_messages == null)
            {
                _messages = new List<string>();
            }
        }

        
        private static void VerifyErrorMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new Exception("Error while trying to add string to ErrorMessage Collection.");
            }
        }

        private static void VerifyMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new Exception("Error while trying to add string to Message Collection.");
            }
        }

        
        protected virtual void VerifyValidity() 
        { 
            if(ErrorMessages == null)
            {
                IsValid = true;
            }
            else
            {
                IsValid = ErrorMessages.Count == 0;
            }
        }

    }
}
