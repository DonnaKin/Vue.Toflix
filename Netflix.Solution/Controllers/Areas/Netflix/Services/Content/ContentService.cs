using Netflix.Solution.Controllers.Areas.Netflix.Models.Common;
using Netflix.Solution.Controllers.Areas.Netflix.Models.Content;

namespace Netflix.Solution.Controllers.Areas.Netflix.Services.Content
{
    public interface IContentService
    {
        CommonResponse<IEnumerable<ContentItem>> GetContentItems();
    }

    public class ContentService : IContentService
    {
        public CommonResponse<IEnumerable<ContentItem>> GetContentItems()
        {
            return new CommonResponse<IEnumerable<ContentItem>>()
            {
                Result = "SUCCESS",
                ErrorCode = "0000",
                ErrorMessage = "",
                Data = CreateItems()
            };
        }


        #region [ 컨텐츠 생성 ]
        private IEnumerable<ContentItem> CreateItems()
        {
            return
            [
                new ContentItem()
                {
                    Code = "TBC001",
                    Category = "serise",
                    Title = "낮과 밤이 다른 그녀",
                    Description = "어쩌다 마법처럼 20대와 50대 나이를 오가게 된 여자. 검찰청에서 인턴으로 일하게 되지만, 꽃다운 청춘과 중년 사이를 넘나들며 까칠한 상사까지 상대해야 한다.",
                    LimitAge = 15,
                    Genre = "코미디 시리즈, 범죄 시리즈, 로맨틱 코미디 시리즈",
                    MainImg = "img_serise_01_main.webp",
                    SummaryImg = "img_serise_01.webp",
                    IsTop = true,
                    IsRecommend = true
                },
                new ContentItem()
                {
                    Code = "TBC002",
                    Category = "serise",
                    Title = "하이라키",
                    Description = "주신고에 새로운 장학생이 등장한다. 전학하고 얼마 되지 않아 교내에 파문을 일으키는 강하. 요란하고 사치스러운 환영 파티에 초대받는데, 그곳에서 도발적인 진실 게임에 참여하게 된다.",
                    LimitAge = 15,
                    Genre = "로맨틱한 드라마, 드라마, 청춘 드라마",
                    MainImg = "img_serise_02_main.webp",
                    SummaryImg = "img_serise_02.webp",
                    IsTop = true,
                    IsRecommend = true
                },
                new ContentItem()
                {
                    Code = "TBC003",
                    Category = "serise",
                    Title = "살인자ㅇ난감",
                    Description = "살인자가 될 생각은 추호도 없었던 이탕. 하지만 악인을 감별해 내는 능력을 자각하고 난 후 정의의 수호자로 새 삶을 시작하게 된다.",
                    LimitAge = 19,
                    Genre = "범죄 시리즈, 웹툰 원작 한국 드라마, 스릴러 시리즈",
                    MainImg = "img_serise_03_main.webp",
                    SummaryImg = "img_serise_03.webp",
                    IsTop = false,
                    IsRecommend = false
                },
                new ContentItem()
                {
                    Code = "TBC004",
                    Category = "serise",
                    Title = "끝내주는 해결사",
                    Description = "까다로운 이혼 분쟁을 처리해 주는 것으로 정평이 난 이혼 해결사. 개인적인 복수를 계획하며, 범상치 않은 팀원들과 함께 사건을 해결해 나간다.",
                    LimitAge = 15,
                    Genre = "코미디 시리즈, 로맨틱 코미디 시리즈, 한국 드라마",
                    MainImg = "img_serise_04_main.webp",
                    SummaryImg = "img_serise_04.webp",
                    IsTop = true,
                    IsRecommend = true
                },
                new ContentItem()
                {
                    Code = "TBC005",
                    Category = "serise",
                    Title = "우리의 지구2",
                    Description = "압도적인 스케일, 경이로운 영상미 그리고 전 인류를 향한 메시지. 우리 지구에 관한 가장 광대한 탐험을 만난다. 자연의 장관과 공존의 철학을 담은 대작 다큐멘터리.",
                    LimitAge = 0,
                    Genre = "가족 시간 TV, 자연 & 생태 다큐멘터리, 과학 & 자연 TV 프로그램",
                    MainImg = "img_serise_05_main.webp",
                    SummaryImg = "img_serise_05.webp",
                    IsTop = false,
                    IsRecommend = false
                },
                new ContentItem()
                {
                    Code = "TBC006",
                    Category = "serise",
                    Title = "더에이트쇼",
                    Description = "웹툰 《머니게임》 《파이게임》에 기반한 시리즈. 거액의 빚을 짊어진 남자가 시간이 쌓이면 돈을 벌 수 있는 미스터리한 쇼에 뛰어든다.",
                    LimitAge = 19,
                    Genre = "드라마, 코미디 시리즈, 웹툰 원작 한국 드라마",
                    MainImg = "img_serise_06_main.webp",
                    SummaryImg = "img_serise_06.webp",
                    IsTop = true,
                    IsRecommend = true
                },
                new ContentItem()
                {
                    Code = "TBC007",
                    Category = "serise",
                    Title = "더글로리",
                    Description = "고등학교 시절 자신을 괴롭힌 사람들에게 복수를 시작하는 여자를 그린 강렬한 드라마.",
                    LimitAge = 19,
                    Genre = "드라마, 한국 드라마",
                    MainImg = "img_serise_07_main.webp",
                    SummaryImg = "img_serise_07.webp",
                    IsTop = false,
                    IsRecommend = false
                },
                new ContentItem()
                {
                    Code = "TBC008",
                    Category = "serise",
                    Title = "아름다웠던 우리에게",
                    Description = "사랑, 달콤할 거라 믿었는데. 사랑, 뭐 이리 어렵기만 한 걸까. 그래도 끝까지 친구로 남고 싶진 않은데. 옆집 소년을 마음에 품은 10대 소녀. 그 첫사랑의 나날 속으로.",
                    LimitAge = 12,
                    Genre = "청춘 드라마, 도서 원작 시리즈, 청소년 시리즈",
                    MainImg = "img_serise_08_main.webp",
                    SummaryImg = "img_serise_08.webp",
                    IsTop = false,
                    IsRecommend = false
                },
                new ContentItem()
                {
                    Code = "TBC009",
                    Category = "serise",
                    Title = "삼겹살 랩소디",
                    Description = "어느 부위 하나 허투루 버리는 법이 없다. 한국인들은 왜 이토록 돼지를 유별나게 즐기는가? 힘들 때나 기쁠 때나 함께해 온 서민 음식. 돼지고기를 찬찬히 뜯어본다.",
                    LimitAge = 0,
                    Genre = "음식 & 여행 시리즈, 다큐 시리즈, 사회 & 문화 다큐멘터리",
                    MainImg = "img_serise_09_main.webp",
                    SummaryImg = "img_serise_09.webp",
                    IsTop = false,
                    IsRecommend = false
                },
                new ContentItem()
                {
                    Code = "TBC010",
                    Category = "serise",
                    Title = "킹더랜드",
                    Description = "뜻깊은 밤을 보낸 후 관계를 발전시켜 나가는 원과 사랑. 이제 두 사람은 사랑이 소중하게 생각하는 누군가의 승낙을 받아야 한다.",
                    LimitAge = 15,
                    Genre = "코미디 시리즈, 로맨틱 코미디 시리즈, 한국 드라마",
                    MainImg = "img_serise_10_main.webp",
                    SummaryImg = "img_serise_10.webp",
                    IsTop = false,
                    IsRecommend = false
                },
                new ContentItem()
                {
                    Code = "TBC011",
                    Category = "serise",
                    Title = "재벌집 막내아들",
                    Description = "그에게 주어진 두 번째 생. 그것은 환생이나 빙의였을까, 시간 여행이었을까. 오너 일가의 지시라면 무조건 따랐던 윤현우. 모든 것을 가진 재벌가의 아들 진도준. 그들의 삶이 겹친 비밀이 밝혀진다.",
                    LimitAge = 15,
                    Genre = "드라마, 한국 드라마",
                    MainImg = "img_serise_11_main.webp",
                    SummaryImg = "img_serise_11.webp",
                    IsTop = false,
                    IsRecommend = false
                },
                new ContentItem()
                {
                    Code = "TBC012",
                    Category = "movie",
                    Title = "서울의 봄",
                    Description = "대한민국의 1979 군사 반란 사건에서 영감을 받은 역사 영화. 서울 사수를 두고 서로 다른 편에 선 두 사령관이 의리와 권력이 첨예하게 얽힌 싸움을 시작한다.",
                    LimitAge = 12,
                    Genre = "스릴러 영화",
                    MainImg = "img_movie_01_main.webp",
                    SummaryImg = "img_movie_01.webp",
                    IsTop = true,
                    IsRecommend = true
                },
                new ContentItem()
                {
                    Code = "TBC013",
                    Category = "movie",
                    Title = "비공식 작전",
                    Description = "동료를 구출해야 하는 위험한 임무를 맡아 홀로 외국 땅에 들어선 외교관. 어쩌다 사기꾼 기질 가득한 택시 기사와 손을 잡는다. 어쩌면 이 기사가 그의 구명줄이 되어줄지도.",
                    LimitAge = 12,
                    Genre = "액션 & 어드벤처 영화",
                    MainImg = "img_movie_02_main.webp",
                    SummaryImg = "img_movie_02.webp",
                    IsTop = false,
                    IsRecommend = false
                },
                new ContentItem()
                {
                    Code = "TBC014",
                    Category = "movie",
                    Title = "시민덕희",
                    Description = "사기 피해를 당해 빈털터리 신세가 된 세탁소 주인. 뜻밖의 조력자와 손을 잡고 보이스피싱 범죄 조직의 소굴을 파헤친다. 실화를 모티브로 한 작품.",
                    LimitAge = 15,
                    Genre = "드라마 영화, 사회 이슈 드라마 장르 영화",
                    MainImg = "img_movie_03_main.webp",
                    SummaryImg = "img_movie_03.webp",
                    IsTop = true,
                    IsRecommend = true
                },
                new ContentItem()
                {
                    Code = "TBC015",
                    Category = "movie",
                    Title = "그놈이다",
                    Description = "내 여동생이 죽어서 돌아왔다. 천도재를 치르던 중 놋그릇이 흘러간 곳에 서 있던 남자. 그리고 죽음을 보는 동네 소녀의 끔찍한 환영. 증거도 목격자도 없지만 그놈이다!",
                    LimitAge = 15,
                    Genre = "스릴러 영화",
                    MainImg = "img_movie_04_main.webp",
                    SummaryImg = "img_movie_04.webp",
                    IsTop = true,
                    IsRecommend = true
                },
                new ContentItem()
                {
                    Code = "TBC016",
                    Category = "movie",
                    Title = "길복순",
                    Description = "긴박감 넘치는 액션 스릴러. 싱글맘으로 사는 삶과 직장 일의 균형을 맞추려 부단히 애쓰는 계약직 킬러의 이야기를 그린다.",
                    LimitAge = 19,
                    Genre = "액션 & 어드벤처 영화",
                    MainImg = "img_movie_05_main.webp",
                    SummaryImg = "img_movie_05.webp",
                    IsTop = false,
                    IsRecommend = false
                },
                new ContentItem()
                {
                    Code = "TBC017",
                    Category = "movie",
                    Title = "20세기 소녀",
                    Description = "때는 바야흐로 90년대의 어느 날. 17세 소녀 나보라가 사랑에 빠진 절친을 위해 큐피드로 나선다. 하지만 소녀에게도 로맨스가 찾아오는데.",
                    LimitAge = 12,
                    Genre = "청춘 드라마 장르, 드라마 영화, 로맨틱한 영화",
                    MainImg = "img_movie_06_main.webp",
                    SummaryImg = "img_movie_06.webp",
                    IsTop = false,
                    IsRecommend = false
                },
                new ContentItem()
                {
                    Code = "TBC018",
                    Category = "movie",
                    Title = "한공주",
                    Description = "음악이 마냥 좋은 평범한 17살 소녀. 끔찍한 사건을 겪은 후 다른 학교로 전학을 간다. 마음을 다잡고 다시 음악을 꿈꾸게 된 것도 잠시, 과거의 망령이 소녀를 찾아온다.",
                    LimitAge = 19,
                    Genre = "드라마 영화",
                    MainImg = "img_movie_07_main.webp",
                    SummaryImg = "img_movie_07.webp",
                    IsTop = false,
                    IsRecommend = false
                },
                new ContentItem()
                {
                    Code = "TBC019",
                    Category = "movie",
                    Title = "트롤",
                    Description = "뜨거운 사랑을 받다가 해체한 보이 밴드. 그로부터 몇 년 뒤, 뜨고 싶어 안달 난 악당들이 멤버 하나를 납치하면서 흩어진 멤버들이 다시 한자리에 모인다. 뮤지컬 어드벤처 영화.",
                    LimitAge = 0,
                    Genre = "음악, 가족 영화, 어린이 & 가족 영화",
                    MainImg = "img_movie_08_main.webp",
                    SummaryImg = "img_movie_08.webp",
                    IsTop = true,
                    IsRecommend = true
                },
                new ContentItem()
                {
                    Code = "TBC020",
                    Category = "movie",
                    Title = "로기완",
                    Description = "탈북까지 감행했지만 여전히 녹록지 않은 현실이 힘겨운 로기완. 그러던 어느 날, 피폐한 삶을 살던 한 여자를 우연히 만나면서 다시 살아갈 이유를 찾게 된다.",
                    LimitAge = 19,
                    Genre = "드라마 영화, 로맨틱한 영화, 도서 원작 영화",
                    MainImg = "img_movie_09_main.webp",
                    SummaryImg = "img_movie_09.webp",
                    IsTop = false,
                    IsRecommend = false
                },
                new ContentItem()
                {
                    Code = "TBC021",
                    Category = "movie",
                    Title = "신비아파트",
                    Description = "100년도 전에 지어진 아파트 단지. 그곳에 사는 하리, 두리 남매에게는 특별한 친구가 있다. 바로 102살 먹은 도깨비 신비! 《신비아파트》 시리즈의 극장판 애니메이션.",
                    LimitAge = 0,
                    Genre = "어린이 & 가족 영화",
                    MainImg = "img_movie_10_main.webp",
                    SummaryImg = "img_movie_10.webp",
                    IsTop = false,
                    IsRecommend = false
                },
                new ContentItem()
                {
                    Code = "TBC022",
                    Category = "movie",
                    Title = "소풍",
                    Description = "수십 년 만에 고향에 돌아온 70대 여인이 유년 시절의 친구와 함께 과거를 회상한다. 두 사람이 함께 보낸 시간과 떨어져 지낸 시간에 대해.",
                    LimitAge = 12,
                    Genre = "드라마 영화, 사회 이슈 드라마 장르 영화",
                    MainImg = "img_movie_11_main.webp",
                    SummaryImg = "img_movie_11.webp",
                    IsTop = false,
                    IsRecommend = false
                }
            ];
        }
        #endregion
    }
}
