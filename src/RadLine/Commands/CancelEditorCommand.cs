namespace RadLine;

public sealed class CancelEditorCommand : LineEditorCommand
{
    public override void Execute(LineEditorContext context)
    {
        context.Submit(SubmitAction.Cancel);
    }
}