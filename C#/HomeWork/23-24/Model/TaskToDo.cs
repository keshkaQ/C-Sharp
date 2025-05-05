

public class TaskToDo
{
    // init - единожды при инициализации, далее нельзя изменить значение
    public string Title { get; set; }
    // required - обязательность заполнения свойства
    public required string Description { get; set; }
    public bool IsComplete { get; private set; }
    

    public void ChangeComplete()
    {
        IsComplete = !IsComplete;
    }
    public override string ToString()
    {
        return $"Title {Title}, Description: {Description}, Status {GetTextComplete()}";
    }
    public string GetTextComplete()
    {
        if (IsComplete)
            return "Завершена";
        return "Активна";
    }
}
