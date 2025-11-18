using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koukinokadai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // それぞれのリールを回すためのタイマー設定
            Timer reel1Timer = new Timer();
            Timer reel2Timer = new Timer();
            Timer reel3Timer = new Timer();

            // ランダムに絵文字を選ぶ
            Random rand = new Random();

            // スロットの絵文字設定
            string[] symbols = { "🤡", "🍒", "🍉", "🍌", "7️⃣" };

            // スコアを設定
            int score = 0;

            // リールが止まったかどうか
            bool reel1Stopped = false;
            bool reel2Stopped = false;
            bool reel3Stopped = false;

        public Form1()
        {
            InitializeComponent();  // フォームの初期化

            // タイマーのTickイベントに処理を追加
            // リールが動いてる間,50msごとにランダムな絵文字を表示
            // sは、sender eは、EventArgs
            reel1Timer.Tick += (s, e) => labelReel1.Text =
            symbols[rand.Next(symbols.Length)];
            reel2Timer.Tick += (s, e) => labelReel2.Text =
            symbols[rand.Next(symbols.Length)];
            reel3Timer.Tick += (s, e) => labelReel3.Text =
            symbols[rand.Next(symbols.Length)];
        }

        // スタートボタンを押したときの処理
        private void btnStart_Click(object sender, EventArgs e)
        {
            // リールの回転速度（interval）を初期設定
            reel1Timer.Interval = 50;     // 50msごとに絵文字切り替え
            reel2Timer.Interval = 50;
            reel3Timer.Interval = 50;

            // タイマーを開始したらリールが回る
            reel1Timer.Start();
            reel2Timer.Start();
            reel3Timer.Start();

            // スタートを押したときにfalse→止まってない状態にする
            reel1Stopped = reel2Stopped = reel3Stopped = false;

        }

        // リール1を止めるボタン
        // async = 時間かかるのを待たずにほかの処理続けられる
        // await = この処理が終わるまで待つがUIは固まらない（asyncで使う）
        private async void btnStop1_Click(object sender, EventArgs e)
        {
            if (!reel1Stopped)   // まだ止まってないとき
            {
                await SlowStop(reel1Timer);
                reel1Stopped = true;
                CheckIfAllStopped();
            }
        }

        // リール2を止めるボタン
        private async void btnStop2_Click(object sender, EventArgs e)
        {
            if (!reel1Stopped)   // まだ止まってないとき
            {
                await SlowStop(reel1Timer);
                reel1Stopped = true;
                CheckIfAllStopped();
            }
        }

        // リール３を止めるボタン
        private async void btnStop3_Click(object sender, EventArgs e)
        {
            if (!reel1Stopped)   // まだ止まってないとき
            {
                await SlowStop(reel1Timer);
                reel1Stopped = true;
                CheckIfAllStopped();
            }
        }

        // リールをだんだん遅くして止める
        private async Task SlowStop(Timer reelTimer)
        {
            // 5回に分けてintervalを増やして回転を遅くする
            for (int i = 0; i < 5; i++)
            {
                // intervalを50msずつ増やす
                reelTimer.Interval += 50;

                // 300ms待機（アニメーション）
                await Task.Delay(300);

            }
            // 停止
            reelTimer.Stop();
        }
        // 全リールが止まったか確認
        private void CheckIfAllStopped()
        {
            if (reel1Stopped && reel2Stopped && reel3Stopped)
            {
                // 全部止まったら結果判定
                CheckResult();
            }
        }

        // 当たり判定とスコア計算
        private void CheckResult()
        {
            // 3つの絵柄が同じなら当たり
            if (labelReel1.Text == labelReel2.Text && labelReel2.Text == labelReel3.Text)
            {
                // 絵柄ごとにスコアを計算
                if (labelReel1.Text == "🤡")
                    score += 500;

                else if (labelReel1.Text == "7️⃣")
                    score += 300;

                else
                    score += 100;

                // スコア表示を更新
                labelScore.Text = $"Score: {score}";

                // 当たりメッセージ
                MessageBox.Show("当たり！");
            }
            else
            {
                // ハズレメッセージ
                MessageBox.Show("ハズレ...");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
}
