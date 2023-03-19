using System;
using Foundation;
using ObjCRuntime;

namespace Drastic.FLEX
{
	// @interface FLEXManager
	interface FLEXManager
	{
		// @property (readonly, nonatomic, class) FLEXManager * sharedManager;
		[Static]
		[Export ("sharedManager")]
		FLEXManager SharedManager { get; }

		// @property (readonly, nonatomic) int isHidden;
		[Export ("isHidden")]
		int IsHidden { get; }

		// @property (readonly, nonatomic) int * toolbar;
		[Export ("toolbar")]
		unsafe int* Toolbar { get; }

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
		void PresentTool (NSObject viewControllerFuture, [NullAllowed] Action completion);

		// -(void)presentEmbeddedTool:(id)viewController completion:(void (^ _Nullable)(int *))completion;
		[Export ("presentEmbeddedTool:completion:")]
		unsafe void PresentEmbeddedTool (NSObject viewController, [NullAllowed] Action<int*> completion);

		// -(void)presentObjectExplorer:(id)object completion:(void (^ _Nullable)(int *))completion;
		[Export ("presentObjectExplorer:completion:")]
		unsafe void PresentObjectExplorer (NSObject @object, [NullAllowed] Action<int*> completion);

		// -(void)showExplorerFromScene:(id)scene;
		[Export ("showExplorerFromScene:")]
		void ShowExplorerFromScene (NSObject scene);

		// @property (copy, nonatomic) int * defaultSqliteDatabasePassword;
		[Export ("defaultSqliteDatabasePassword", ArgumentSemantic.Copy)]
		unsafe int* DefaultSqliteDatabasePassword { get; set; }
	}

	// typedef int * _Nullable (^FLEXCustomContentViewerFuture)(int *);
	unsafe delegate int* FLEXCustomContentViewerFuture (int* arg0);
}
