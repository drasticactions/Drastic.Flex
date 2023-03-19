using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Drastic.FLEX
{
	// @interface FLEXManager
	[BaseType (typeof(NSObject))]
	interface FLEXManager
	{
		// @property (readonly, nonatomic, class) FLEXManager * sharedManager;
		[Static]
		[Export ("sharedManager")]
		FLEXManager SharedManager { get; }

		// @property (readonly, nonatomic) int isHidden;
		[Export ("isHidden")]
		int IsHidden { get; }

		// -(void)showExplorer;
		[Export ("showExplorer")]
		void ShowExplorer ();

		// -(void)hideExplorer;
		[Export ("hideExplorer")]
		void HideExplorer ();

		// -(void)toggleExplorer;
		[Export ("toggleExplorer")]
		void ToggleExplorer ();

		// -(void)dismissAnyPresentedTools:(void (^ _Nullable)(void))completion;
		[Export ("dismissAnyPresentedTools:")]
		void DismissAnyPresentedTools ([NullAllowed] Action completion);

		// -(void)presentTool:(id)viewControllerFuture completion:(void (^ _Nullable)(void))completion;
		[Export ("presentTool:completion:")]
		void PresentTool (UIViewController viewControllerFuture, [NullAllowed] Action completion);

		// -(void)showExplorerFromScene:(id)scene;
		[Export ("showExplorerFromScene:")]
		void ShowExplorerFromScene (NSObject scene);
	}
}
