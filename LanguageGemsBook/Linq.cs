namespace LanguageGemsBook;

public class Linq
{
    public void method()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

        // from 절
        // 데이터 원본으로부터 범위 변수 뽑아내기
        // 데이터 원본은 `IEnumerable<T>`의 파생 형식이어야 함
        var result = from n in numbers
            where n % 2 == 0
            orderby n
            select n;

        Profile[] arrProfile =
        {
            new Profile() { Name = "정우성", Height = 186 },
            new Profile() { Name = "김태희", Height = 158 },
            new Profile() { Name = "고현정", Height = 172 },
            new Profile() { Name = "이문세", Height = 178 },
            new Profile() { Name = "하동훈", Height = 171 },
        };
        
        // where 절
        // 범위 변수의 조건 필터
        var profiles = from profile in arrProfile
            where profile.Height < 175
            select profile;
        
        // orderby 절
        // 데이터 정렬
        var profiles2 = from profile in arrProfile
            where profile.Height < 175
            orderby profile.Height descending
            select profile;
        
        // select 절
        // 최종 결과 추출
        // IEnumerable<T>로 반환 됨
        var profiles3 = from profile in arrProfile
            where profile.Height < 175
            orderby profile.Height descending
            select profile.Name;

        var profiles4 = from profile in arrProfile
            where profile.Height < 175
            orderby profile.Height descending
            select new { Name = profile.Name, InchHeight = profile.Height * 0.393 };
        
        // group by절
        var listProfile = from profile in arrProfile
            orderby profile.Height
            group profile by profile.Height < 175 into g
            select new { GroupKey = g.Key, Profiles = g };
        
        // inner join
        // 교집합을 반환
        // 기준은 첫번째 원본 데이터
        Product[] arrProduct =
        {
            new Product() { Title = "비트", Star = "정우성" },
            new Product() { Title = "CF 다수", Star = "김태희" },
            new Product() { Title = "아이리스", Star = "김태희" },
            new Product() { Title = "모래시계", Star = "고현정" },
            new Product() { Title = "Solo 예찬", Star = "이문세" },
        };

        var innerJoin = from profile in arrProfile
            join product in arrProduct on profile.Name equals product.Star
            select new
            {
                Name = profile.Name,
                Work = product.Title,
                Height = profile.Height
            };
        
        // outer join
        // 기준이 되는 데이터 원본의 모든 것을 조인 결과에 포함
        // 과정
        //  1. join 절을 이용해 조인을 수행 후 그 결과를 임시 컬렉션에 저장
        //  2. DefaultIfEmpty 연산을 통해 임시 컬렉션의 비어 있는 조인 결과에 빈 값 삽입
        //  3. DefaultIfEmpty 연산을 거친 임시 컬렉션에서 다시 from절을 통해 범위 변수 추출
        //  4. 범위 변수와 기준 데이터 원본에서 뽑아낸 범위 변수를 이용해 최종 결과 추출
        var outerJoin = from profile in arrProfile
            join product in arrProduct on profile.Name equals product.Star into ps
            from sub_product in ps.DefaultIfEmpty(new Product() { Title = "그런거 없음" })
            select new
            {
                Name = profile.Name,
                Work = sub_product.Title,
                Height = profile.Height
            };
        
        // LINQ 표준 연산자
        var profilesStandard = arrProfile
            .Where(profile => profile.Height < 175)
            .OrderBy(profile => profile.Height)
            .Select(profile =>
                new
                {
                    Name = profile.Name,
                    InchHeight = profile.Height * 0.393
                });
        
        // LINQ 쿼리 식과 메소드 함께 사용
        // 따로 쓰기
        var profiles5 = from profile in arrProfile
            where profile.Height < 180
            select profile;
        double Average = profiles5.Average(profile => profile.Height);

        // 같이 쓰기
        double Average2 = (from profile in arrProfile
            where profile.Height < 180
            select profile).Average(profile => profile.Height);

        // Select 절에 쓰기
        var heightStat = from profile in arrProfile
            group profile by profile.Height < 175
            into g
            select new
            {
                Group = g.Key == true ? "175미만" : "175이상",
                Count = g.Count(),
                Max = g.Max(profile => profile.Height),
                Min = g.Min(profile => profile.Height),
                Average = g.Average(profile => profile.Height)
            };
    }
}

class Profile
{
    public string Name
    {
        get;
        set;
    }

    public int Height
    {
        get;
        set;
    }
}

class Product
{
    public string Title
    {
        get;
        set;
    }

    public string Star
    {
        get;
        set;
    }
}