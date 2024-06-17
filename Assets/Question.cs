using static Globals;

// parent class of all questions
public abstract class Question {

  // class for each question
  public Dimension Dimension { get; }
  public Question(Dimension dimension) {
    Dimension = dimension;
  }
}

public class FirstQuestion: Question {

  public string Content { get;}

  public FirstQuestion(string content, Dimension dimension) : base(dimension) {
    Content = content;
  }
}

public class SecondQuestion: Question {

  public string AbstractContent { get; }
  public string SituationalContent { get; }

  public SecondQuestion(string abstractContent, string situationalContent, Dimension dimension) : base(dimension) {
    AbstractContent = abstractContent;
    SituationalContent = situationalContent;
  }
}