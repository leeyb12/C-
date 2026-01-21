// INotifyPropertyChanged 구현 시 nameof를 사용

public class Rectangle : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    private double width;
    private double height;

    public double width
    {
        get { return width; }
        set
        {
            if (width == value)  // 값이 변경되지 않았으면 이벤트를 발생시키지 않음
            {
                return;
            }
            width = value;
            RaisePropertyChanged();  // Width 속성이 변경되었음을 알리는 이벤트 발생
            RaisePropertyChanged(nameof(Area));  // Area 속성이 변경되었음을 알리는 이벤트 발생
        }
    }

    public double Height { ... }  // Width 속성과 동일하게 구현

    public double Area => Width * Height;  // 속성값 계산

    private void RaisePropertyChanged(  // 7.2절에서 살펴본 변경 통지
        [CallerMemberName] string propertyName = null) { ... }
}