namespace Krdn.Maui.ApplicationCore.Entities;

// 다른 키 유형을 지원하도록 Base Entity<T> 및 공개 T Id로 쉽게 수정할 수 있습니다.
// 단순성과 캐싱 논리를 용이하게 하기 위해 제네릭이 아닌 정수 유형 사용
public abstract class BaseEntity
{
    // Id 를 non-generic integer 로 사용하는 이유는 간단하게 설명하면,
    // 다양한 키 타입을 지원하기 위함이다.
    // 캐싱 로직을 쉽게 하기 위해서이기도 하다.
    //
    public virtual int Id { get; protected set; }
}

