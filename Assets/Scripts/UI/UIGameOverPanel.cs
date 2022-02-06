using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using Saro.UI;
using Saro;
using Cysharp.Threading.Tasks;

namespace Tetris.UI
{
    public sealed partial class UIGameOverPanel : SingletonUI<UIGameOverPanel, UIBinder>
    {
        #region Impl

        protected override void InternalStart()
        {
        }

        protected override void InternalUpdate(float deltaTime)
        {
        }

        protected override void InternalClose()
        {
        }

        protected override void InternalAwake()
        {
            GetComps();

            Listen(btn_replay.onClick, OnClick_Replay);
            Listen(btn_setting.onClick, OnClick_Setting);
            Listen(btn_about.onClick, OnClick_About);
            Listen(btn_quit.onClick, () =>
            {
                Main.Quit();
            });
        }

        private void OnClick_Replay()
        {
            UIComponent.Current.AddToast("未开启");
        }

        private void OnClick_Setting()
        {
            UIComponent.Current.OpenUIAsync<UISetting>().Forget();
        }

        private void OnClick_About()
        {
            UIComponent.Current.OpenUIAsync<UIAboutPanel>().Forget();
        }

        #endregion
    }

    // =============================================
    // code generate between >>begin and <<end
    // don't modify this scope

    //>>begin

    public partial class UIGameOverPanel
    {
		private UnityEngine.UI.Button btn_replay;
		private UnityEngine.UI.Button btn_setting;
		private UnityEngine.UI.Button btn_about;
		private UnityEngine.UI.Button btn_quit;

		void GetComps()
		{
			btn_replay = Binder.Get<UnityEngine.UI.Button>("btn_replay");
			btn_setting = Binder.Get<UnityEngine.UI.Button>("btn_setting");
			btn_about = Binder.Get<UnityEngine.UI.Button>("btn_about");
			btn_quit = Binder.Get<UnityEngine.UI.Button>("btn_quit");
		}
	}

	//<<end

    // =============================================
}
