// INotifyPropertyChanged 구현 시 호출자 정보 특성 사용

// 속성 세터 수정
if (value != firstValue)
{
    firstValue = value;
    NotifyPropertyChanged();
}

void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
{
// 메서드 본문은 이전과 동일
}