using Microsoft.EntityFrameworkCore;

namespace G26W09WFSnackList;

public class (18) : DbContext
{
    public DbSet<Snack>(19)                                     { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // snacks.db 파일로 저장
        optionsBuilder.UseSqlite("(20)                          =snacks.db");
    }

    public void AddInitSnack()
    {
        (19).AddRange(new Snack[] {
        new("동대문 엽기떡볶이", "하루 시험 4과목 스트레스", "https://images.unsplash.com/photo-1747228469541-f0e7f56e7ec7?w=400&h=400&fit=crop"),
        new("탕후루", "뭔 과제가 이렇게 많아", "https://images.unsplash.com/photo-1551024709-8f23befc6f87?w=400&h=400&fit=crop"),
        new("황금올리브 치킨", "과제 제출 마감 1분 전에 인터넷 공유기 다운됨", "https://images.unsplash.com/photo-1626082927389-6cd097cdc6ec?w=400&h=400&fit=crop"),
        new("까르보 불닭볶음면", "수강신청 올클 실패하고 잔여석 0개", "https://images.unsplash.com/photo-1585032226651-759b368d7246?w=400&h=400&fit=crop"),
        new("허니콤보 치킨", "중간고사 시험지 받고 멘탈 바사삭", "https://images.unsplash.com/photo-1527477396000-e27163b481c2?w=400&h=400&fit=crop"),
        new("마라탕 (매운맛 3단계)", "밤샘 과제 하려고 산 에너지 음료를 키보드에 통째로 쏟아버림", "https://images.unsplash.com/photo-1569718212165-3a8278d5f624?w=400&h=400&fit=crop"),
        new("아이스 카페라떼 벤티", "밤샘 과제 4일째, 커피가 피 대신 흐름", "https://images.unsplash.com/photo-1541167760496-1628856ab772?w=400&h=400&fit=crop"),
        new("편의점 자이언트 떡볶이", "지하철 놓쳐서 지각 확정", "https://images.unsplash.com/photo-1541658016709-82535e94bc69?w=400&h=400&fit=crop"),
        new("슈퍼콘 초코", "강의실 잘못 찾아가서 중간고사 결시 위기", "https://images.unsplash.com/photo-1563805042-7684c019e1cb?w=400&h=400&fit=crop"),
        new("냉동 피자 한 판", "코딩 과제 컴파일 에러 100개 돌파", "https://images.unsplash.com/photo-1513104890138-7c749659a591?w=400&h=400&fit=crop"),
        new("베스킨라빈스 파인트", "발표 수업 때 PPT 날려먹음", "https://images.unsplash.com/photo-1560008511-11c63416e52d?w=400&h=400&fit=crop"),
        new("불닭마요 덮밥", "강의실 앞에서 동기 만나서 오늘 시험인 거 처음 알게 됨", "https://images.unsplash.com/photo-1550547660-d9450f859349?w=400&h=400&fit=crop"),
        new("소곱창 구이", "분명히 정답이라고 적어낸 문제 싹 다 틀림", "https://images.unsplash.com/photo-1544025162-d76694265947?w=400&h=400&fit=crop"),
        new("타코야키 세트", "아침 9시 전공 수업인데 알람 소리 못 듣고 8시 55에 깸", "https://images.unsplash.com/photo-1534422298391-e4f8c172dddb?w=400&h=400&fit=crop"),
        new("닭강정 대짜", "AI한테 코딩 과제 시켰더니 존재하지 않는 가짜 라이브러리 함수 사용", "https://images.unsplash.com/photo-1527477396000-e27163b481c2?w=400&h=400&fit=crop"),
        new("치즈볼 6개", "에러 하나 고치려고 코드 한 줄 건드렸더니 에러가 50개로 복제됨", "https://images.unsplash.com/photo-1541592106381-b31e9677c0e5?w=400&h=400&fit=crop"),
        new("맥도날드 빅맥 세트", "팀플 발표 혼자 총대 메고 발표함", "https://images.unsplash.com/photo-1568901346375-23c9450c58cd?w=400&h=400&fit=crop"),
        new("짜파게티 2봉지 + 계란", "비대면 강의 녹화본이 날아감", "https://images.unsplash.com/photo-1585032226651-759b368d7246?w=400&h=400&fit=crop"),
        new("허니버터칩 큰팩", "노트북 배터리 충전기 안 들고 와서 도서관에서 절전 모드 진입", "https://images.unsplash.com/photo-1566478989037-eec170784d0b?w=400&h=400&fit=crop"),
        new("딸기 생크림 케이크", "드디어 이번 학기 종강 맞이 기념", "https://images.unsplash.com/photo-1578985545062-69928b1d9587?w=400&h=400&fit=crop")
        });

        // 실제로 데이터베이스에 저장
        (14)();
    }
}
