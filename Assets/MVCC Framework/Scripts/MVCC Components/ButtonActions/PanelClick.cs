public class PanelClick : IButtonActions {

	public void ExecuteClick(AppElement sender)
    {
        sender.app.Notify((int)NOTIFYEVENT.CLICKGETINPUTTEXT_CLASS, null, null);
    }
	
}
