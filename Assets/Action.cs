using System;
using static Globals;

  public class Action{

    // all variables are final - can only be initialized in constructor and cannot be changed
    public DateTime Timestamp { get; }
    // only the index of the target question; the index refers to orderedQuestionList in process manager
    public int QuestionId { get; }

    public ActionType Type { get; }

    // if the action type is not 'modify', set to -1 by default; change accordingly if the type is 'modify'
    public int PreviousValue { get; } = -1;
    public int NewValue { get; } = -1;

    public Action(DateTime timestamp, int questionId, ActionType type) {
      Timestamp = timestamp;
      QuestionId = questionId;
      Type = type;
    }

    public Action(DateTime timestamp, int questionId, ActionType type, int previousValue, int newValue) : this(timestamp, questionId, type) {
      PreviousValue = previousValue;
      NewValue = newValue;
    }
  }