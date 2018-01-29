README:

MVCC for Unity 1.0

# App.cs is the base;

# Use the prefab to add to scene the basics;

=== Guidelines ===

# Do not use Singletons for controllers

Exmaples of Singletons: SoundManager, ARKitManager, PluginManager

# Avoid cross reference Controllers/Elements

to access controllers fire a notification with p_target set and create proper logic for that

# GameObjects/references belongs to Controllers

# Split Controller by funcionality (UIController, FlowController, DataController, etc)

# Elements / Views dont have access to GameObjects/References

use AppElement script to create views to mostly fire events based on Input (UI, events of other kinds)

# Model : Create all models and reference then in your AppModel.cs

to access the specific model later just use:

	app.model.DBConnect.GetData( (data) => {
		// Do something with data
	});

try to use Actions where possible to return data to the app flow

models dont have references to objects or base App class

use AppModelBase to create static references and common methods

# NOTIFYEVENT enum: you need to create your enumerations

Create like:

	UI_OPEN_WINDOW
	UI_CLOSE_WINDOW
	FLOW_CLOSE_ALL_VIEWS
	
In this manner you can better understand what each "path" can do

Multiple controller can have the same path to execute different tasks

=== Known Issues ===

# After creating NOTIFYEVENT Enumeration avoid change its order: The PressManager.cs uses its order

=== Future Features ===

# Register/Unregister Controllers

# Override for Model objects
	- Add Models on the fly
	- Reference models outside the app.model initial access

# Override for Controller objects
	- Standard events for AR, Unity, System