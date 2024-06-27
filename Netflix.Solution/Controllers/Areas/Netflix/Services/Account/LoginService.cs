using Netflix.Solution.Controllers.Areas.Netflix.Models.Account;
using Netflix.Solution.Controllers.Areas.Netflix.Models.Common;

namespace Netflix.Solution.Controllers.Areas.Netflix.Services.Account
{
    public interface ILoginService
    {
        CommonResponse<AuthInfo> Login(LoginParameter loginParameter);
    }

    public class LoginService : ILoginService
    {
        public CommonResponse<AuthInfo> Login(LoginParameter loginParameter)
        {
            if (loginParameter.Uid == "test@tobecon.net" && loginParameter.Password == "tobecon_dkagh")
            {
                return new CommonResponse<AuthInfo>()
                {
                    Result = "SUCCESS",
                    ErrorCode = "0000",
                    ErrorMessage = "",
                    Data = new AuthInfo()
                    {
                        Uid = "test@tobecon.net",
                        PassWord = "tobecon_dkagh",
                        Birth = "1993",
                        FavoriteList = ["TBC001", "TBC002"],
                        WatchingList = ["TBC002", "TBC003"]
                    }
                };
            }
            else
            {
                return new CommonResponse<AuthInfo>()
                {
                    Result = "SUCCESS",
                    ErrorCode = "1000",
                    ErrorMessage = "아이디 또는 비밀번호를 확인하세요.",
                    Data = new AuthInfo()
                    {
                        Uid = "",
                        PassWord = "",
                        Birth = "",
                        FavoriteList = [],
                        WatchingList = []
                    }
                };
            }
        }
    }
}
