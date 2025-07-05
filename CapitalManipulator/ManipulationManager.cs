using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;

namespace CapitalManipulator;

/// <summary>
/// Manages the manipulation.
/// </summary>
public class ManipulationManager {
    private static readonly Random Rand = new();

    /// <summary>
    /// Do a random prank:
    /// 1. Shutdown
    /// 2. Show fake BSOD screen
    /// 3. Shake the mouse
    /// 4. Speak capital truth
    /// 5. Message storm
    /// 6. Never Gonna Give You Up
    /// </summary>
    /// <param name="form">The form that called this.</param>
    public static void ExecuteRandomPrank(Form form) {
        int choice = Rand.Next(5);
        switch (choice) {
            case 0: Shutdown(); break;
            case 1: ShowFakeBsod(); break;
            case 2: ShakeMouse(); break;
            case 3: SpeakCapitalTruth(); break;
            case 4: MessageStorm(); break;
            case 5: RickRoll(); break;
        }
    }

    private static void Shutdown() {
        Console.WriteLine("Shutting down...");
        Process.Start("shutdown", "/s /t 5");
    }

    private static async void ShowFakeBsod() {
        Form bsod = new Form {
            FormBorderStyle = FormBorderStyle.None,
            WindowState = FormWindowState.Maximized,
            BackColor = Color.DarkBlue,
            TopMost = true
        };

        Label text = new Label {
            Text = """
                   :)

                   你的电脑没有遇到任何问题，且不需要重启。我们不收集任何错误信息，然后也不会为你重新启动。
                   Your PC did not run into a problem and does not need to restart. We're not collecting any error info, and we'll not restart for you either.

                   好吧不演了，其实这是资本家布局多年的结果。资本家说这个局布了好久，所以肯定不能短短几秒就帮你关上这个屏幕。
                   Okay let's not pretend anymore. This is actually the result of a long-term plan by the capitalists. The capitalists say they've been planning this for a long time, so they definitely can't just close this for you in a few seconds.

                   时间只是有亿点点长，你小子就耐心等着吧。
                   It's just a littttttttle biiiiiiiit loooooooong, so just wait patiently, my kid.
                   """,
            ForeColor = Color.White,
            Font = new Font("Consolas", 18),
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleLeft
        };

        bsod.Controls.Add(text);
        bsod.Show();
        await Task.Delay(50000);
        bsod.Close();
    }

    [DllImport("user32.dll")]
    static extern bool SetCursorPos(int x, int y);

    private static async void ShakeMouse() {
        Point original = Cursor.Position;
        for (int i = 0; i < 100; i++) {
            int offsetX = Rand.Next(-1000, 1000);
            int offsetY = Rand.Next(-1000, 1000);
            SetCursorPos(original.X + offsetX, original.Y + offsetY);
            await Task.Delay(30);
        }

        SetCursorPos(original.X, original.Y);
    }

    private static void SpeakCapitalTruth() {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        for (int i = 0; i < 5; i++) {
            synth.SpeakAsync(
                "孩子，不要动资本的蛋糕，后果很严重。My child, do not touch the capital's cake, or there will be serious consequences.");
        }
    }

    private static async void MessageStorm() {
        for (int i = 0; i < 30; i++) {
            Task.Run(() =>
                MessageBox.Show("哈哈哈，你被资本做局了！\nHahaha, you've been set up by capital!", "资本警告 Capital Warning"));
            await Task.Delay(100);
        }
    }

    private static void RickRoll() {
        Process.Start(new ProcessStartInfo("https://www.bilibili.com/video/BV1GJ411x7h7/") {
            UseShellExecute = true
        });
    }
}