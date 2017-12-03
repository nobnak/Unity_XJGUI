﻿using UnityEngine;
using XJGUI;

public class Sample : MonoBehaviour
{
    FlexibleWindow flexibleWindow;

    //TabPanel tabPanel;
    //FoldoutPanel foldOutPanel;

    //BoolGUI boolGUI;
    //IntGUI intGUI;
    //FloatGUI floatGUI;

    Vector2GUI vector2GUI;

    //Toolbar toolBar;
    //IPv4GUI ipv4GUI;

    void Start()
    {
        this.flexibleWindow = new FlexibleWindow()
        {
            minWidth  = 300,
            minHeight = 300,
        };

        //this.tabPanel = new TabPanel() { Labels = new string[] { "Value", "Else" } };

        //this.foldOutPanel = new FoldoutPanel() { Title = "Vector", Value = false };

        //this.boolGUI = new BoolGUI() { Title = "Bool Value", BoldTitle = true, Value = false };

        //this.intGUI = new IntGUI() { Title = "int Value", MinValue = 0, MaxValue = 100, };

        //this.floatGUI = new FloatGUI() { Title = "float Value", Value = 50, MinValue = 0, MaxValue = 100, Decimals = 3, };

        this.vector2GUI = new Vector2GUI() { Value = new Vector2(0.5f, 0.5f), Title = "Vector2 Value", Decimals = 1, MinValue = new Vector2(-1, -1), MaxValue = new Vector2(1, 1) };

        //this.toolBar = new Toolbar() { Title = "Toolbar", Labels = new string[] { "A", "B", "C" } };

        //this.ipv4GUI = new IPv4GUI() { Title = "IPV4", Value = "7.7.7.7", };
    }

    void OnGUI()
    {
        this.flexibleWindow.Show(() =>
        {
            this.vector2GUI.Show();

            //this.tabPanel.Show(() =>
            //{
            //    this.boolGUI.Show();
            //    this.intGUI.Show();
            //    this.floatGUI.Show();

            //    this.foldOutPanel.Show(() =>
            //    {
            //        this.floatGUI.Show();
            //    });

            //    this.toolBar.Show();
            //    this.ipv4GUI.Show();
            //});
        });
    }
}