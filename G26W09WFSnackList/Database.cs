using Microsoft.EntityFrameworkCore;

namespace G26W09WFSnackList;

public class SnackDatabaseSet : DbContext // (18)
{
    public DbSet<Snack> Tuples { get; set; } // (19)

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
        optionsBuilder.UseSqlite("Data Source=snacks.db"); // (20)
    }

    public void AddInitSnack()
    {
        Tuples.AddRange(new Snack[] {
            new("김치찌개", "전공 시험을 망쳐서 스트레스를 받음",
                "https://images.unsplash.com/photo-1547592180-85f173990554?w=400"),

            new("후라이드 치킨", "팀 프로젝트 회의가 길어져서 피곤함",
                "https://images.unsplash.com/photo-1626082927389-6cd097cdc6ec?w=400"),

            new("페퍼로니 피자", "프로그래밍 과제에서 오류가 계속 발생함",
                "https://images.unsplash.com/photo-1513104890138-7c749659a591?w=400"),

            new("치즈버거", "아침 수업에 지각해서 기분이 좋지 않음",
                "https://images.unsplash.com/photo-1568901346375-23c9450c58cd?w=400"),

            new("초콜릿 아이스크림", "시험공부를 오래 해서 당이 당김",
                "https://images.unsplash.com/photo-1563805042-7684c019e1cb?w=400"),

            new("라면", "늦은 밤까지 코딩 과제를 진행함",
                "https://images.unsplash.com/photo-1569718212165-3a8278d5f624?w=400"),

            new("딸기 케이크", "어려운 시험을 끝낸 기념으로 먹고 싶음",
                "https://images.unsplash.com/photo-1578985545062-69928b1d9587?w=400"),

            new("아이스 카페라떼", "오전 수업을 듣느라 피곤함",
                "https://images.unsplash.com/photo-1541167760496-1628856ab772?w=400"),

            new("감자튀김", "팀 프로젝트에서 의견 충돌이 발생함",
                "https://images.unsplash.com/photo-1573080496219-bb080dd4f877?w=400"),

            new("타코야키", "과제 제출 시간이 얼마 남지 않음",
                "https://images.unsplash.com/photo-1534422298391-e4f8c172dddb?w=400"),

            new("치킨너겟", "프로그램 실행 중 예상하지 못한 오류가 발생함",
                "https://images.unsplash.com/photo-1527477396000-e27163b481c2?w=400"),

            new("불닭볶음면", "수강신청에 실패해서 스트레스를 받음",
                "https://images.unsplash.com/photo-1585032226651-759b368d7246?w=400"),

            new("소고기 스테이크", "중간고사 기간이 끝나서 기분이 좋음",
                "https://images.unsplash.com/photo-1544025162-d76694265947?w=400"),

            new("치즈볼", "발표 도중 준비한 내용을 잊어버림",
                "https://images.unsplash.com/photo-1541592106381-b31e9677c0e5?w=400"),

            new("핫도그", "오랜 시간 공부해서 배가 고픔",
                "https://images.unsplash.com/photo-1612392062798-2e36c16b6d7e?w=400"),

            new("초코 쿠키", "데이터베이스 연결 오류를 해결하지 못함",
                "https://images.unsplash.com/photo-1499636136210-6f4ee915583e?w=400"),

            new("샌드위치", "점심시간이 부족해서 간단한 음식이 필요함",
                "https://images.unsplash.com/photo-1528735602780-2552fd46c7af?w=400"),

            new("마카롱", "팀 프로젝트 결과가 기대에 미치지 못함",
                "https://images.unsplash.com/photo-1569864358642-9d1684040f43?w=400"),

            new("짜장면", "프로그래밍 실습 문제를 해결하지 못함",
                "https://images.unsplash.com/photo-1585032226651-759b368d7246?w=400"),

            new("과일 샐러드", "모든 과제를 제출한 후 가볍게 먹고 싶음",
                "https://images.unsplash.com/photo-1512621776951-a57141f2eefd?w=400")


        });

        // 실제로 데이터베이스에 저장
        SaveChanges(); // (14)
    }
}