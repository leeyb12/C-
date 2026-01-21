// 예전 방식의 INotifyPropertyChanged 구현 예

class OldPropertyNotifier : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    private int firstValue;
    public int FirstValue 
    {
        get { return firstValue; }
        set
        {
            if (value != firstValue)
            {
                firstValue = value;
                NotifyPropertyChanged("FirstValue");
            }
        }
    }

    // (다른 속성들도 유사한 패턴으로 구현)

    private void NotifyPropertyChanged(string propertyName)
    {
        PropertyChangedEventHandler handler = PropertyChanged;
        if (headler != null)
        {
            handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}