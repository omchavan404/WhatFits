using server.Interfaces;
using System.Collections.Generic;
using System.Security.Claims;

namespace server.Model.Data_Transfer_Objects.AccountDTO_s
{
    public class LoginResponseDTO : IResponseDTO
    {
        public List<string> Messages { get; set; }
        public bool isSuccessful { get; set; }

        public string username { get; set; }
        public string token { get; set; }
        public List<string> viewclaims { get; set; }
    }
}