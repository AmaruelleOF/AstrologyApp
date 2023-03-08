﻿using System.Windows;
using System.Windows.Media;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls.Window;

namespace AstrologyApp
{
    public partial class IntroWindow : FluentWindow
    {
        public IntroWindow()
        {
            InitializeComponent();
            FontFamily = new FontFamily("Segoe UI");
            Theme.Apply(ThemeType.Light, WindowBackdropType.Mica, false);
            var primaryAccent = Color.FromRgb(103, 80, 164);
            Accent.Apply(primaryAccent, ThemeType.Light, false);
            var intro_text = @"Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.
                Здесь будет располагаться текст соглашения, он будет длинный и важный,
                а сейчас здесь просто плейсхолдер в пару строк.";
            IntroText.Text = intro_text;
        }

        private void EnterBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var wind = new MainW();
            Close();
            wind.Show();
        }
    }
}