﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Uno.UITest.Helpers.Queries;
using Uno.UITests.Helpers;

namespace Uno.Gallery.UITests
{
	public class Given_CheckBox_02_Material_Secondary : TestBase
	{
		/*     
        * This function is to test the Unchecked option  in checkbox for material, 
        */
		[Test]
		public void WhenMaterialClickSecondary_01_Unchecked()
		{
			NavigateToSample("CheckBox");
			ShowMaterialTheme();

			TakeScreenshot("Before Checked");

			var materialSecondaryUncheckedBox = App.WaitThenTap("Material_Secondary_Unchecked").ToQueryEx();

			TakeScreenshot("After Checked");

			//Assert.IsFalse(materialSecondaryUncheckedBox.GetDependencyPropertyValue<bool>("IsChecked"));
			Assert.IsTrue(materialSecondaryUncheckedBox.GetDependencyPropertyValue<bool>("IsChecked"));
		}

		/*     
        * This function is to test the DisabledUnchecked option  in checkbox for material.
        */
		[Test]
		public void WhenMaterialClickSecondary_02_DisabledUnchecked()
		{
			NavigateToSample("CheckBox");
			ShowMaterialTheme();

			TakeScreenshot("Before Checked");

			var materialSecondaryDisabledUncheckedBox = App.WaitThenTap("Material_Secondary_Disabled_Unchecked").ToQueryEx();

			TakeScreenshot("After Checked");

			//Assert.IsFalse(materialSecondaryDisabledUncheckedBox.GetDependencyPropertyValue<bool>("IsEnabled"));
			Assert.IsTrue(materialSecondaryDisabledUncheckedBox.GetDependencyPropertyValue<bool>("IsEnabled"));
		}

		/*     
		 * This function is to test the Checked option in checkbox for material.    
		 */
		[Test]
		public void WhenMaterialClickSecondary_03_Checked()
		{
			NavigateToSample("CheckBox");
			ShowMaterialTheme();

			TakeScreenshot("Before UnChecked");

			var materialSecondaryCheckedBox = App.WaitThenTap("Material_Secondary_Checked").ToQueryEx();

			TakeScreenshot("After UnChecked");

			//Assert.IsFalse(materialSecondaryCheckedBox.GetDependencyPropertyValue<bool>("IsChecked"));
			Assert.IsTrue(materialSecondaryCheckedBox.GetDependencyPropertyValue<bool>("IsChecked"));
		}

		/*     
        * This function is to test the DisabledChecked option  in checkbox for material, 
        */
		[Test]
		public void WhenMaterialClickSecondary_04_DisabledChecked()
		{
			NavigateToSample("CheckBox");
			ShowMaterialTheme();

			TakeScreenshot("Before Checked");

			var materialSecondaryDisabledCheckedBox = App.WaitThenTap("Material_Secondary_Disabled_Checked").ToQueryEx();

			TakeScreenshot("After Checked");

			//Assert.IsFalse(materialSecondaryDisabledCheckedBox.GetDependencyPropertyValue<bool>("IsEnabled"));

			Assert.IsTrue(materialSecondaryDisabledCheckedBox.GetDependencyPropertyValue<bool>("IsEnabled"));
			Assert.IsTrue(materialSecondaryDisabledCheckedBox.GetDependencyPropertyValue<bool>("IsChecked"));
		}

		/*     
        * This function is to test the Indeterminate for uncheck, recheck and indeterminate option  in checkbox for material, 
        */
		[Test]
		public void WhenMaterialClickSecondary_05_Indeterminate()
		{
			NavigateToSample("CheckBox");
			ShowMaterialTheme();

			TakeScreenshot("Before UnChecked");

			var materialSecondaryCheckedIndeterminateBox = App.WaitThenTap("Material_Secondary_Indeterminate").ToQueryEx();

			TakeScreenshot("After UnChecked");

			//Assert.IsFalse(materialSecondaryCheckedIndeterminateBox.GetDependencyPropertyValue<bool>("IsChecked"));
			Assert.IsTrue(materialSecondaryCheckedIndeterminateBox.GetDependencyPropertyValue<bool>("IsChecked"));
			
			var materialSecondaryRecheckIndeterminateBox = App.WaitThenTap("Material_Secondary_Indeterminate").ToQueryEx();

			TakeScreenshot("After Checked");

			//Assert.IsFalse(materialSecondaryRecheckIndeterminateBox.GetDependencyPropertyValue<bool>("IsChecked"));
			Assert.IsTrue(materialSecondaryRecheckIndeterminateBox.GetDependencyPropertyValue<bool>("IsChecked"));

			var materialSecondaryReUncheckIndeterminateBox = App.WaitThenTap("Material_Secondary_Indeterminate").ToQueryEx();

			TakeScreenshot("After Checked");

			//Assert.IsFalse(materialSecondaryReUncheckIndeterminateBox.GetDependencyPropertyValue<bool>("IsChecked"));
			Assert.IsTrue(materialSecondaryReUncheckIndeterminateBox.GetDependencyPropertyValue<bool>("IsChecked"));
		}
		
		/*     
        * This function is to test the DisabledIndeterminate option  in checkbox for material.
        */
		[Test]
		public void WhenMaterialClickSecondary_06_DisabledIndeterminate()
		{
			NavigateToSample("CheckBox");
			ShowMaterialTheme();

			TakeScreenshot("Before Checked");

			var materialSecondaryDisabledIndeterminateBox = App.WaitThenTap("Material_Secondary_Disabled_Indeterminate").ToQueryEx();

			TakeScreenshot("After Checked");

			//Assert.IsFalse(materialSecondaryDisabledIndeterminateBox.GetDependencyPropertyValue<bool>("IsEnabled"));
			Assert.IsTrue(materialSecondaryDisabledIndeterminateBox.GetDependencyPropertyValue<bool>("IsEnabled"));
		}
	}
}