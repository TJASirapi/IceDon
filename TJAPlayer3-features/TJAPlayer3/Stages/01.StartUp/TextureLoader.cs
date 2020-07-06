using FDK;

namespace TJAPlayer3
{
    class TextureLoader
    {
        const string BASE = @"Graphics\";

        // Stage
        const string TITLE = @"1_Title\";
        const string CONFIG = @"2_Config\";
        const string SONGSELECT = @"3_SongSelect\";
        const string SONGLOADING = @"4_SongLoading\";
        const string GAME = @"5_Game\";
        const string RESULT = @"6_Result\";
        const string EXIT = @"7_Exit\";

        // InGame
        const string CHARA = @"1_Chara\";
        const string DANCER = @"2_Dancer\";
        const string MOB = @"3_Mob\";
        const string COURSESYMBOL = @"4_CourseSymbol\";
        const string BACKGROUND = @"5_Background\";
        const string TAIKO = @"6_Taiko\";
        const string GAUGE = @"7_Gauge\";
        const string FOOTER = @"8_Footer\";
        const string END = @"9_End\";
        const string EFFECTS = @"10_Effects\";
        const string BALLOON = @"11_Balloon\";
        const string LANE = @"12_Lane\";
        const string GENRE = @"13_Genre\";
        const string GAMEMODE = @"14_GameMode\";
        const string FAILED = @"15_Failed\";
        const string RUNNER = @"16_Runner\";
        const string PUCHICHARA = @"18_PuchiChara\";
        const string TRAINING = @"19_Training\";
        const string DANC = @"17_DanC\";

        // InGame_Effects
        const string FIRE = @"Fire\";
        const string HIT = @"Hit\";
        const string ROLL = @"Roll\";
        const string SPLASH = @"Splash\";


        public TextureLoader()
        {
            // コンストラクタ

        }

        internal CTexture TxC(string FileName)
        {
            return TJAPlayer3.tテクスチャの生成(CSkin.Path(BASE + FileName));
        }
        internal CTextureAf TxCAf(string FileName)
        {
            return TJAPlayer3.tテクスチャの生成Af(CSkin.Path(BASE + FileName));
        }
        internal CTexture TxCGen(string FileName)
        {
            return TJAPlayer3.tテクスチャの生成(CSkin.Path(BASE + GAME + GENRE + FileName + ".png"));
        }

        public void LoadTexture()
        {
            #region 共通
            Tile_Black = TxC(@"Tile_Black.png");
            Tile_White = TxC(@"Tile_White.png");
            Menu_Title = TxC(@"Menu_Title.png");
            Menu_Highlight = TxC(@"Menu_Highlight.png");
            Enum_Song = TxC(@"Enum_Song.png");
            Scanning_Loudness = TxC(@"Scanning_Loudness.png");
            Overlay = TxC(@"Overlay.png");
            NamePlate[0] = TxC(@"1P_NamePlate.png");
            NamePlate[1] = TxC(@"2P_NamePlate.png");
            #endregion
            #region 1_タイトル画面
            Title_Background = TxC(TITLE + @"Background.png");
            Title_Menu = TxC(TITLE + @"Menu.png");
            #endregion

            #region 2_コンフィグ画面
            Config_Background = TxC(CONFIG + @"Background.png");
            Config_Cursor = TxC(CONFIG + @"Cursor.png");
            Config_ItemBox = TxC(CONFIG + @"ItemBox.png");
            Config_Arrow = TxC(CONFIG + @"Arrow.png");
            Config_KeyAssign = TxC(CONFIG + @"KeyAssign.png");
            Config_Font = TxC(CONFIG + @"Font.png");
            Config_Font_Bold = TxC(CONFIG + @"Font_Bold.png");
            Config_Enum_Song = TxC(CONFIG + @"Enum_Song.png");
            #endregion

            #region 3_選曲画面
            SongSelect_Background = TxC(SONGSELECT + @"Background.png");
            SongSelect_Header = TxC(SONGSELECT + @"Header.png");
            SongSelect_Footer = TxC(SONGSELECT + @"Footer.png");
            SongSelect_Difficulty = TxC(SONGSELECT + @"Difficulty.png");
            SongSelect_Auto = TxC(SONGSELECT + @"Auto.png");
            SongSelect_Level = TxC(SONGSELECT + @"Level.png");
            SongSelect_Branch = TxC(SONGSELECT + @"Branch.png");
            SongSelect_Branch_Text = TxC(SONGSELECT + @"Branch_Text.png");
            SongSelect_Bar_Center = TxC(SONGSELECT + @"Bar_Center.png");
            SongSelect_Frame_Score = TxC(SONGSELECT + @"Frame_Score.png");
            SongSelect_Frame_BackBox = TxC(SONGSELECT + @"Frame_BackBox.png");
            SongSelect_Frame_Random = TxC(SONGSELECT + @"Frame_Random.png");
            SongSelect_Score_Select = TxC(SONGSELECT + @"Score_Select.png");
            //SongSelect_Frame_Dani = TxC(SONGSELECT + @"Frame_Dani.png");
            SongSelect_GenreText = TxC(SONGSELECT + @"GenreText.png");
            SongSelect_Cursor_Left = TxC(SONGSELECT + @"Cursor_Left.png");
            SongSelect_Cursor_Right = TxC(SONGSELECT + @"Cursor_Right.png");
            for (int i = 0; i < SongSelect_Bar_Genre.Length; i++)
            {
                SongSelect_Bar_Genre[i] = TxC(SONGSELECT + @"Bar_Genre_" + i.ToString() + ".png");
            }
            for (int i = 0; i < SongSelect_Frame_Box.Length; i++)
            {
                SongSelect_Frame_Box[i] = TxC(SONGSELECT + @"Frame_Box_" + i.ToString() + ".png");
            }
            for (int i = 0; i < (int)Difficulty.Total; i++)
            {
                SongSelect_ScoreWindow[i] = TxC(SONGSELECT + @"ScoreWindow_" + i.ToString() + ".png");
            }

            for (int i = 0; i < SongSelect_GenreBack.Length; i++)
            {
                SongSelect_GenreBack[i] = TxC(SONGSELECT + @"GenreBackground_" + i.ToString() + ".png");
            }
            SongSelect_ScoreWindow_Text = TxC(SONGSELECT + @"ScoreWindow_Text.png");
            SongSelect_Rating = TxC(SONGSELECT + @"Rating.png");
            #endregion

            #region 4_読み込み画面
            SongLoading_Plate = TxC(SONGLOADING + @"Plate.png");
            SongLoading_FadeIn = TxC(SONGLOADING + @"FadeIn.png");
            SongLoading_FadeOut = TxC(SONGLOADING + @"FadeOut.png");
            #endregion

            #region 5_演奏画面
            #region 共通
            Notes = TxC(GAME + @"Notes.png");
            Judge_Frame = TxC(GAME + @"Notes.png");
            SENotes = TxC(GAME + @"SENotes.png");
            Notes_Arm = TxC(GAME + @"Notes_Arm.png");
            Judge = TxC(GAME + @"Judge.png");

            Bar = TxC(GAME + @"Bar.png");
            Bar_Branch = TxC(GAME + @"Bar_Branch.png");

            #endregion
            #region キャラクター
            TJAPlayer3.Skin.Game_Chara_Ptn_Normal = TJAPlayer3.t連番画像の枚数を数える(CSkin.Path(BASE + GAME + CHARA + @"Normal\"));
            if (TJAPlayer3.Skin.Game_Chara_Ptn_Normal != 0)
            {
                Chara_Normal = new CTexture[TJAPlayer3.Skin.Game_Chara_Ptn_Normal];
                for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_Normal; i++)
                {
                    Chara_Normal[i] = TxC(GAME + CHARA + @"Normal\" + i.ToString() + ".png");
                }
            }
            TJAPlayer3.Skin.Game_Chara_Ptn_Clear = TJAPlayer3.t連番画像の枚数を数える(CSkin.Path(BASE + GAME + CHARA + @"Clear\"));
            if (TJAPlayer3.Skin.Game_Chara_Ptn_Clear != 0)
            {
                Chara_Normal_Cleared = new CTexture[TJAPlayer3.Skin.Game_Chara_Ptn_Clear];
                for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_Clear; i++)
                {
                    Chara_Normal_Cleared[i] = TxC(GAME + CHARA + @"Clear\" + i.ToString() + ".png");
                }
            }
            if (TJAPlayer3.Skin.Game_Chara_Ptn_Clear != 0)
            {
                Chara_Normal_Maxed = new CTexture[TJAPlayer3.Skin.Game_Chara_Ptn_Clear];
                for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_Clear; i++)
                {
                    Chara_Normal_Maxed[i] = TxC(GAME + CHARA + @"Clear_Max\" + i.ToString() + ".png");
                }
            }
            TJAPlayer3.Skin.Game_Chara_Ptn_GoGo = TJAPlayer3.t連番画像の枚数を数える(CSkin.Path(BASE + GAME + CHARA + @"GoGo\"));
            if (TJAPlayer3.Skin.Game_Chara_Ptn_GoGo != 0)
            {
                Chara_GoGoTime = new CTexture[TJAPlayer3.Skin.Game_Chara_Ptn_GoGo];
                for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_GoGo; i++)
                {
                    Chara_GoGoTime[i] = TxC(GAME + CHARA + @"GoGo\" + i.ToString() + ".png");
                }
            }
            if (TJAPlayer3.Skin.Game_Chara_Ptn_GoGo != 0)
            {
                Chara_GoGoTime_Maxed = new CTexture[TJAPlayer3.Skin.Game_Chara_Ptn_GoGo];
                for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_GoGo; i++)
                {
                    Chara_GoGoTime_Maxed[i] = TxC(GAME + CHARA + @"GoGo_Max\" + i.ToString() + ".png");
                }
            }

            TJAPlayer3.Skin.Game_Chara_Ptn_10combo = TJAPlayer3.t連番画像の枚数を数える(CSkin.Path(BASE + GAME + CHARA + @"10combo\"));
            if (TJAPlayer3.Skin.Game_Chara_Ptn_10combo != 0)
            {
                Chara_10Combo = new CTexture[TJAPlayer3.Skin.Game_Chara_Ptn_10combo];
                for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_10combo; i++)
                {
                    Chara_10Combo[i] = TxC(GAME + CHARA + @"10combo\" + i.ToString() + ".png");
                }
            }
            TJAPlayer3.Skin.Game_Chara_Ptn_10combo_Max = TJAPlayer3.t連番画像の枚数を数える(CSkin.Path(BASE + GAME + CHARA + @"10combo_Max\"));
            if (TJAPlayer3.Skin.Game_Chara_Ptn_10combo_Max != 0)
            {
                Chara_10Combo_Maxed = new CTexture[TJAPlayer3.Skin.Game_Chara_Ptn_10combo_Max];
                for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_10combo_Max; i++)
                {
                    Chara_10Combo_Maxed[i] = TxC(GAME + CHARA + @"10combo_Max\" + i.ToString() + ".png");
                }
            }

            TJAPlayer3.Skin.Game_Chara_Ptn_GoGoStart = TJAPlayer3.t連番画像の枚数を数える(CSkin.Path(BASE + GAME + CHARA + @"GoGoStart\"));
            if (TJAPlayer3.Skin.Game_Chara_Ptn_GoGoStart != 0)
            {
                Chara_GoGoStart = new CTexture[TJAPlayer3.Skin.Game_Chara_Ptn_GoGoStart];
                for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_GoGoStart; i++)
                {
                    Chara_GoGoStart[i] = TxC(GAME + CHARA + @"GoGoStart\" + i.ToString() + ".png");
                }
            }
            TJAPlayer3.Skin.Game_Chara_Ptn_GoGoStart_Max = TJAPlayer3.t連番画像の枚数を数える(CSkin.Path(BASE + GAME + CHARA + @"GoGoStart_Max\"));
            if (TJAPlayer3.Skin.Game_Chara_Ptn_GoGoStart_Max != 0)
            {
                Chara_GoGoStart_Maxed = new CTexture[TJAPlayer3.Skin.Game_Chara_Ptn_GoGoStart_Max];
                for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_GoGoStart_Max; i++)
                {
                    Chara_GoGoStart_Maxed[i] = TxC(GAME + CHARA + @"GoGoStart_Max\" + i.ToString() + ".png");
                }
            }
            TJAPlayer3.Skin.Game_Chara_Ptn_ClearIn = TJAPlayer3.t連番画像の枚数を数える(CSkin.Path(BASE + GAME + CHARA + @"ClearIn\"));
            if (TJAPlayer3.Skin.Game_Chara_Ptn_ClearIn != 0)
            {
                Chara_Become_Cleared = new CTexture[TJAPlayer3.Skin.Game_Chara_Ptn_ClearIn];
                for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_ClearIn; i++)
                {
                    Chara_Become_Cleared[i] = TxC(GAME + CHARA + @"ClearIn\" + i.ToString() + ".png");
                }
            }
            TJAPlayer3.Skin.Game_Chara_Ptn_SoulIn = TJAPlayer3.t連番画像の枚数を数える(CSkin.Path(BASE + GAME + CHARA + @"SoulIn\"));
            if (TJAPlayer3.Skin.Game_Chara_Ptn_SoulIn != 0)
            {
                Chara_Become_Maxed = new CTexture[TJAPlayer3.Skin.Game_Chara_Ptn_SoulIn];
                for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_SoulIn; i++)
                {
                    Chara_Become_Maxed[i] = TxC(GAME + CHARA + @"SoulIn\" + i.ToString() + ".png");
                }
            }
            TJAPlayer3.Skin.Game_Chara_Ptn_Balloon_Breaking = TJAPlayer3.t連番画像の枚数を数える(CSkin.Path(BASE + GAME + CHARA + @"Balloon_Breaking\"));
            if (TJAPlayer3.Skin.Game_Chara_Ptn_Balloon_Breaking != 0)
            {
                Chara_Balloon_Breaking = new CTexture[TJAPlayer3.Skin.Game_Chara_Ptn_Balloon_Breaking];
                for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_Balloon_Breaking; i++)
                {
                    Chara_Balloon_Breaking[i] = TxC(GAME + CHARA + @"Balloon_Breaking\" + i.ToString() + ".png");
                }
            }
            TJAPlayer3.Skin.Game_Chara_Ptn_Balloon_Broke = TJAPlayer3.t連番画像の枚数を数える(CSkin.Path(BASE + GAME + CHARA + @"Balloon_Broke\"));
            if (TJAPlayer3.Skin.Game_Chara_Ptn_Balloon_Broke != 0)
            {
                Chara_Balloon_Broke = new CTexture[TJAPlayer3.Skin.Game_Chara_Ptn_Balloon_Broke];
                for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_Balloon_Broke; i++)
                {
                    Chara_Balloon_Broke[i] = TxC(GAME + CHARA + @"Balloon_Broke\" + i.ToString() + ".png");
                }
            }
            TJAPlayer3.Skin.Game_Chara_Ptn_Balloon_Miss = TJAPlayer3.t連番画像の枚数を数える(CSkin.Path(BASE + GAME + CHARA + @"Balloon_Miss\"));
            if (TJAPlayer3.Skin.Game_Chara_Ptn_Balloon_Miss != 0)
            {
                Chara_Balloon_Miss = new CTexture[TJAPlayer3.Skin.Game_Chara_Ptn_Balloon_Miss];
                for (int i = 0; i < TJAPlayer3.Skin.Game_Chara_Ptn_Balloon_Miss; i++)
                {
                    Chara_Balloon_Miss[i] = TxC(GAME + CHARA + @"Balloon_Miss\" + i.ToString() + ".png");
                }
            }
            #endregion
            #region 踊り子
            TJAPlayer3.Skin.Game_Dancer_Ptn = TJAPlayer3.t連番画像の枚数を数える(CSkin.Path(BASE + GAME + DANCER + @"1\"));
            if (TJAPlayer3.Skin.Game_Dancer_Ptn != 0)
            {
                for (int i = 0; i < Dancer.Length; i++)
                {
                    Dancer[i] = new CTexture[TJAPlayer3.Skin.Game_Dancer_Ptn];
                    for (int p = 0; p < TJAPlayer3.Skin.Game_Dancer_Ptn; p++)
                    {
                        Dancer[i][p] = TxC(GAME + DANCER + (i + 1) + @"\" + p.ToString() + ".png");
                    }
                }
            }
            #endregion
            #region モブ
            TJAPlayer3.Skin.Game_Mob_Ptn = TJAPlayer3.t連番画像の枚数を数える(CSkin.Path(BASE + GAME + MOB));
            Mob = new CTexture[TJAPlayer3.Skin.Game_Mob_Ptn];
            for (int i = 0; i < TJAPlayer3.Skin.Game_Mob_Ptn; i++)
            {
                Mob[i] = TxC(GAME + MOB + i.ToString() + ".png");
            }
            #endregion
            #region フッター
            Mob_Footer = TxC(GAME + FOOTER + @"0.png");
            #endregion
            #region 背景
            Background = TxC(GAME + Background + @"0\" + @"Background.png");
            Background_Up[0] = TxC(GAME + BACKGROUND + @"0\" + @"1P_Up.png");
            Background_Up[1] = TxC(GAME + BACKGROUND + @"0\" + @"2P_Up.png");
            Background_Up_Clear[0] = TxC(GAME + BACKGROUND + @"0\" + @"1P_Up_Clear.png");
            Background_Up_Clear[1] = TxC(GAME + BACKGROUND + @"0\" + @"2P_Up_Clear.png");
            Background_Down = TxC(GAME + BACKGROUND + @"0\" + @"Down.png");
            Background_Down_Clear = TxC(GAME + BACKGROUND + @"0\" + @"Down_Clear.png");
            Background_Down_Scroll = TxC(GAME + BACKGROUND + @"0\" + @"Down_Scroll.png");

            #endregion
            #region 太鼓
            Taiko_Background[0] = TxC(GAME + TAIKO + @"1P_Background.png");
            Taiko_Background[1] = TxC(GAME + TAIKO + @"2P_Background.png");
            Taiko_Frame[0] = TxC(GAME + TAIKO + @"1P_Frame.png");
            Taiko_Frame[1] = TxC(GAME + TAIKO + @"2P_Frame.png");
            Taiko_PlayerNumber[0] = TxC(GAME + TAIKO + @"1P_PlayerNumber.png");
            Taiko_PlayerNumber[1] = TxC(GAME + TAIKO + @"2P_PlayerNumber.png");
            Taiko_NamePlate[0] = TxC(GAME + TAIKO + @"1P_NamePlate.png");
            Taiko_NamePlate[1] = TxC(GAME + TAIKO + @"2P_NamePlate.png");
            Taiko_Base = TxC(GAME + TAIKO + @"Base.png");
            Taiko_Don_Left = TxC(GAME + TAIKO + @"Don.png");
            Taiko_Don_Right = TxC(GAME + TAIKO + @"Don.png");
            Taiko_Ka_Left = TxC(GAME + TAIKO + @"Ka.png");
            Taiko_Ka_Right = TxC(GAME + TAIKO + @"Ka.png");
            Taiko_LevelUp = TxC(GAME + TAIKO + @"LevelUp.png");
            Taiko_LevelDown = TxC(GAME + TAIKO + @"LevelDown.png");
            for (int i = 0; i < Course_Symbol.Length; i++)
            {
                Course_Symbol[i] = TxC(GAME + COURSESYMBOL + Course_Symbols[i] + ".png");
            }
            Taiko_Score[0] = TxC(GAME + TAIKO + @"Score.png");
            Taiko_Score[1] = TxC(GAME + TAIKO + @"Score_1P.png");
            Taiko_Score[2] = TxC(GAME + TAIKO + @"Score_2P.png");
            Taiko_Combo[0] = TxC(GAME + TAIKO + @"Combo.png");
            Taiko_Combo[1] = TxC(GAME + TAIKO + @"Combo_Big.png");
            Taiko_Combo_Effect = TxC(GAME + TAIKO + @"Combo_Effect.png");
            Taiko_Combo_Text = TxC(GAME + TAIKO + @"Combo_Text.png");
            #endregion
            #region ゲージ
            Gauge[0] = TxC(GAME + GAUGE + @"1P.png");
            Gauge[1] = TxC(GAME + GAUGE + @"2P.png");
            Gauge_Hard[0] = TxC(GAME + GAUGE + @"1P_Hard.png");
            Gauge_Hard[1] = TxC(GAME + GAUGE + @"2P_Hard.png");
            Gauge_ExHard[0] = TxC(GAME + GAUGE + @"1P_ExHard.png");
            Gauge_ExHard[1] = TxC(GAME + GAUGE + @"2P_ExHard.png");
            Gauge_Base[0] = TxC(GAME + GAUGE + @"1P_Base.png");
            Gauge_Base[1] = TxC(GAME + GAUGE + @"2P_Base.png");
            Gauge_Base_Hard[0] = TxC(GAME + GAUGE + @"1P_Base_Hard.png");
            Gauge_Base_Hard[1] = TxC(GAME + GAUGE + @"2P_Base_Hard.png");
            Gauge_Base_ExHard[0] = TxC(GAME + GAUGE + @"1P_Base_ExHard.png");
            Gauge_Base_ExHard[1] = TxC(GAME + GAUGE + @"2P_Base_ExHard.png");
            Gauge_Line[0] = TxC(GAME + GAUGE + @"1P_Line.png");
            Gauge_Line[1] = TxC(GAME + GAUGE + @"2P_Line.png");
            Gauge_Line_Hard[0] = TxC(GAME + GAUGE + @"1P_Line_Hard.png");
            Gauge_Line_Hard[1] = TxC(GAME + GAUGE + @"2P_Line_Hard.png");
            TJAPlayer3.Skin.Game_Gauge_Rainbow_Ptn = TJAPlayer3.t連番画像の枚数を数える(CSkin.Path(BASE + GAME + GAUGE + @"Rainbow\"));
            if (TJAPlayer3.Skin.Game_Gauge_Rainbow_Ptn != 0)
            {
                Gauge_Rainbow = new CTexture[TJAPlayer3.Skin.Game_Gauge_Rainbow_Ptn];
                for (int i = 0; i < TJAPlayer3.Skin.Game_Gauge_Rainbow_Ptn; i++)
                {
                    Gauge_Rainbow[i] = TxC(GAME + GAUGE + @"Rainbow\" + i.ToString() + ".png");
                }
            }
            Gauge_Soul = TxC(GAME + GAUGE + @"Soul.png");
            Gauge_Soul_Fire = TxC(GAME + GAUGE + @"Fire.png");
            Gauge_Soul_Explosion[0] = TxC(GAME + GAUGE + @"1P_Explosion.png");
            Gauge_Soul_Explosion[1] = TxC(GAME + GAUGE + @"2P_Explosion.png");
            #endregion
            #region 吹き出し
            Balloon_Combo[0] = TxC(GAME + BALLOON + @"Combo_1P.png");
            Balloon_Combo[1] = TxC(GAME + BALLOON + @"Combo_2P.png");
            Balloon_Roll = TxC(GAME + BALLOON + @"Roll.png");
            Balloon_Balloon = TxC(GAME + BALLOON + @"Balloon.png");
            Balloon_Number_Roll = TxC(GAME + BALLOON + @"Number_Roll.png");
            Balloon_Number_Combo = TxC(GAME + BALLOON + @"Number_Combo.png");

            for (int i = 0; i < Balloon_Breaking.Length; i++)
            {
                Balloon_Breaking[i] = TxC(GAME + BALLOON + @"Breaking_" + i.ToString() + ".png");
            }
            #endregion
            #region エフェクト
            Effects_Hit_Explosion = TxCAf(GAME + EFFECTS + @"Hit\Explosion.png");
            if (Effects_Hit_Explosion != null) Effects_Hit_Explosion.b加算合成 = TJAPlayer3.Skin.Game_Effect_HitExplosion_AddBlend;
            Effects_Hit_Explosion_Big = TxC(GAME + EFFECTS + @"Hit\Explosion_Big.png");
            if (Effects_Hit_Explosion_Big != null) Effects_Hit_Explosion_Big.b加算合成 = TJAPlayer3.Skin.Game_Effect_HitExplosionBig_AddBlend;
            Effects_Hit_FireWorks = TxC(GAME + EFFECTS + @"Hit\FireWorks.png");
            if (Effects_Hit_FireWorks != null) Effects_Hit_FireWorks.b加算合成 = TJAPlayer3.Skin.Game_Effect_FireWorks_AddBlend;


            Effects_Fire = TxC(GAME + EFFECTS + @"Fire.png");
            if (Effects_Fire != null) Effects_Fire.b加算合成 = TJAPlayer3.Skin.Game_Effect_Fire_AddBlend;

            Effects_Rainbow = TxC(GAME + EFFECTS + @"Rainbow.png");

            Effects_GoGoSplash = TxC(GAME + EFFECTS + @"GoGoSplash.png");
            if (Effects_GoGoSplash != null) Effects_GoGoSplash.b加算合成 = TJAPlayer3.Skin.Game_Effect_GoGoSplash_AddBlend;
            for (int i = 0; i < Effects_Hit_Good.Length; i++)
            {
                Effects_Hit_Good[i] = TxC(GAME + EFFECTS + @"Hit\" + @"Good\" + i.ToString() + ".png");
                Effects_Hit_Good_Big[i] = TxC(GAME + EFFECTS + @"Hit\" + @"Good_Big\" + i.ToString() + ".png");
                Effects_Hit_Great[i] = TxC(GAME + EFFECTS + @"Hit\" + @"Great\" + i.ToString() + ".png");
                Effects_Hit_Great_Big[i] = TxC(GAME + EFFECTS + @"Hit\" + @"Great_Big\" + i.ToString() + ".png");
            }
            TJAPlayer3.Skin.Game_Effect_Roll_Ptn = TJAPlayer3.t連番画像の枚数を数える(CSkin.Path(BASE + GAME + EFFECTS + @"Roll\"));
            Effects_Roll = new CTexture[TJAPlayer3.Skin.Game_Effect_Roll_Ptn];
            for (int i = 0; i < TJAPlayer3.Skin.Game_Effect_Roll_Ptn; i++)
            {
                Effects_Roll[i] = TxC(GAME + EFFECTS + @"Roll\" + i.ToString() + ".png");
            }
            #endregion
            #region レーン
            string[] Lanes = new string[3] { "Normal", "Expert", "Master" };
            for (int i = 0; i < Lane_Base.Length; i++)
            {
                Lane_Base[i] = TxC(GAME + LANE + "Base_" + Lanes[i] + ".png");
                Lane_Text[i] = TxC(GAME + LANE + "Text_" + Lanes[i] + ".png");
            }
            Lane_Red = TxC(GAME + LANE + @"Red.png");
            Lane_Blue = TxC(GAME + LANE + @"Blue.png");
            Lane_Yellow = TxC(GAME + LANE + @"Yellow.png");
            Lane_Background_Main = TxC(GAME + LANE + @"Background_Main.png");
            Lane_Background_Sub = TxC(GAME + LANE + @"Background_Sub.png");
            Lane_Background_GoGo = TxC(GAME + LANE + @"Background_GoGo.png");

            #endregion
            #region 終了演出
            for (int i = 0; i < End_Clear_L.Length; i++)
            {
                End_Clear_L[i] = TxC(GAME + END + @"Clear_L_" + i.ToString() + ".png");
                End_Clear_R[i] = TxC(GAME + END + @"Clear_R_" + i.ToString() + ".png");
            }
            End_Clear_Text = TxC(GAME + END + @"Clear_Text.png");
            End_Clear_Text_Effect = TxC(GAME + END + @"Clear_Text_Effect.png");
            if (End_Clear_Text_Effect != null) End_Clear_Text_Effect.b加算合成 = true;
            #endregion
            #region ゲームモード
            GameMode_Timer_Tick = TxC(GAME + GAMEMODE + @"Timer_Tick.png");
            GameMode_Timer_Frame = TxC(GAME + GAMEMODE + @"Timer_Frame.png");
            #endregion
            #region ステージ失敗
            Failed_Game = TxC(GAME + FAILED + @"Game.png");
            Failed_Stage = TxC(GAME + FAILED + @"Stage.png");
            #endregion
            #region ランナー
            Runner = TxC(GAME + RUNNER + @"0.png");
            #endregion
            #region DanC
            DanC_Background = TxC(GAME + DANC + @"Background.png");
            DanC_Gauge = new CTexture[4];
            var type = new string[] { "Normal", "Reach", "Clear", "Flush" };
            for (int i = 0; i < 4; i++)
            {
                DanC_Gauge[i] = TxC(GAME + DANC + @"Gauge_" + type[i] + ".png");
            }
            DanC_Base = TxC(GAME + DANC + @"Base.png");
            DanC_Failed = TxC(GAME + DANC + @"Failed.png");
            DanC_Number = TxC(GAME + DANC + @"Number.png");
            DanC_ExamType = TxC(GAME + DANC + @"ExamType.png");
            DanC_ExamRange = TxC(GAME + DANC + @"ExamRange.png");
            DanC_ExamUnit = TxC(GAME + DANC + @"ExamUnit.png");
            DanC_Screen = TxC(GAME + DANC + @"Screen.png");
            #endregion
            #region PuichiChara
            PuchiChara = TxC(GAME + PUCHICHARA + @"0.png");
            #endregion
            #region Training
            Tokkun_DownBG = TxC(GAME + TRAINING + @"Down.png");
            Tokkun_BigTaiko = TxC(GAME + TRAINING + @"BigTaiko.png");
            Tokkun_ProgressBar = TxC(GAME + TRAINING + @"ProgressBar_Red.png");
            Tokkun_ProgressBarWhite = TxC(GAME + TRAINING + @"ProgressBar_White.png");
            Tokkun_GoGoPoint = TxC(GAME + TRAINING + @"GoGoPoint.png");
            Tokkun_Background_Up = TxC(GAME + TRAINING + @"Background_Up.png");
            Tokkun_BigNumber = TxC(GAME + TRAINING + @"BigNumber.png");
            Tokkun_SmallNumber = TxC(GAME + TRAINING + @"SmallNumber.png");
            #endregion
            #endregion

            #region 6_結果発表
            Result_Background = TxC(RESULT + @"Background.png");
            Result_FadeIn = TxC(RESULT + @"FadeIn.png");
            Result_Gauge = TxC(RESULT + @"Gauge.png");
            Result_Gauge_Base = TxC(RESULT + @"Gauge_Base.png");
            Result_Gauge_Hard = TxC(RESULT + @"Gauge_Hard.png");
            Result_Gauge_ExHard = TxC(RESULT + @"Gauge_ExHard.png");
            Result_Gauge_Base_Hard = TxC(RESULT + @"Gauge_Base_Hard.png");
            Result_Gauge_Base_ExHard = TxC(RESULT + @"Gauge_Base_ExHard.png");
            Result_Judge = TxC(RESULT + @"Judge.png");
            Result_Header = TxC(RESULT + @"Header.png");
            Result_Number = TxC(RESULT + @"Number.png");
            Result_Panel = TxC(RESULT + @"Panel.png");
            Result_Score_Text = TxC(RESULT + @"Score_Text.png");
            Result_Score_Number = TxC(RESULT + @"Score_Number.png");
            Result_Dan = TxC(RESULT + @"Dan.png");
            #endregion

            #region 7_終了画面
            Exit_Background = TxC(EXIT + @"Background.png");
            #endregion

        }

        public void DisposeTexture()
        {
            TJAPlayer3.t安全にDisposeする(ref Title_Background);
            TJAPlayer3.t安全にDisposeする(ref Title_Menu);
            #region 共通
            TJAPlayer3.t安全にDisposeする(ref Tile_Black);
            TJAPlayer3.t安全にDisposeする(ref Tile_White);
            TJAPlayer3.t安全にDisposeする(ref Menu_Title);
            TJAPlayer3.t安全にDisposeする(ref Menu_Highlight);
            TJAPlayer3.t安全にDisposeする(ref Enum_Song);
            TJAPlayer3.t安全にDisposeする(ref Scanning_Loudness);
            TJAPlayer3.t安全にDisposeする(ref Overlay);
            TJAPlayer3.t安全にDisposeする(NamePlate);

            #endregion
            #region 1_タイトル画面
            TJAPlayer3.t安全にDisposeする(ref Title_Background);
            TJAPlayer3.t安全にDisposeする(ref Title_Menu);
            #endregion

            #region 2_コンフィグ画面
            TJAPlayer3.t安全にDisposeする(ref Config_Background);
            TJAPlayer3.t安全にDisposeする(ref Config_Cursor);
            TJAPlayer3.t安全にDisposeする(ref Config_ItemBox);
            TJAPlayer3.t安全にDisposeする(ref Config_Arrow);
            TJAPlayer3.t安全にDisposeする(ref Config_KeyAssign);
            TJAPlayer3.t安全にDisposeする(ref Config_Font);
            TJAPlayer3.t安全にDisposeする(ref Config_Font_Bold);
            TJAPlayer3.t安全にDisposeする(ref Config_Enum_Song);
            #endregion

            #region 3_選曲画面
            TJAPlayer3.t安全にDisposeする(ref SongSelect_Background);
            TJAPlayer3.t安全にDisposeする(ref SongSelect_Header);
            TJAPlayer3.t安全にDisposeする(ref SongSelect_Footer);
            TJAPlayer3.t安全にDisposeする(ref SongSelect_Difficulty);
            TJAPlayer3.t安全にDisposeする(ref SongSelect_Auto);
            TJAPlayer3.t安全にDisposeする(ref SongSelect_Level);
            TJAPlayer3.t安全にDisposeする(ref SongSelect_Branch);
            TJAPlayer3.t安全にDisposeする(ref SongSelect_Branch_Text);
            TJAPlayer3.t安全にDisposeする(ref SongSelect_Bar_Center);
            TJAPlayer3.t安全にDisposeする(ref SongSelect_Frame_Score);
            TJAPlayer3.t安全にDisposeする(ref SongSelect_Frame_BackBox);
            TJAPlayer3.t安全にDisposeする(ref SongSelect_Frame_Random);
            TJAPlayer3.t安全にDisposeする(ref SongSelect_Score_Select);
            TJAPlayer3.t安全にDisposeする(ref SongSelect_GenreText);
            TJAPlayer3.t安全にDisposeする(ref SongSelect_Cursor_Left);
            TJAPlayer3.t安全にDisposeする(ref SongSelect_Cursor_Right);
            TJAPlayer3.t安全にDisposeする(SongSelect_Bar_Genre);
            TJAPlayer3.t安全にDisposeする(SongSelect_Frame_Box);
            TJAPlayer3.t安全にDisposeする(SongSelect_ScoreWindow);
            TJAPlayer3.t安全にDisposeする(SongSelect_GenreBack);
            TJAPlayer3.t安全にDisposeする(ref SongSelect_ScoreWindow_Text);
            TJAPlayer3.t安全にDisposeする(ref SongSelect_Rating);
            #endregion

            #region 4_読み込み画面
            TJAPlayer3.t安全にDisposeする(ref SongLoading_Plate);
            TJAPlayer3.t安全にDisposeする(ref SongLoading_FadeIn);
            TJAPlayer3.t安全にDisposeする(ref SongLoading_FadeOut);
            #endregion

            #region 5_演奏画面
            #region 共通
            TJAPlayer3.t安全にDisposeする(ref Notes);
            TJAPlayer3.t安全にDisposeする(ref Judge_Frame);
            TJAPlayer3.t安全にDisposeする(ref SENotes);
            TJAPlayer3.t安全にDisposeする(ref Notes_Arm);
            TJAPlayer3.t安全にDisposeする(ref Judge);

            TJAPlayer3.t安全にDisposeする(ref Bar);
            TJAPlayer3.t安全にDisposeする(ref Bar_Branch);

            #endregion
            #region キャラクター

            TJAPlayer3.t安全にDisposeする(Chara_Normal);
            TJAPlayer3.t安全にDisposeする(Chara_Normal_Cleared);
            TJAPlayer3.t安全にDisposeする(Chara_Normal_Maxed);
            TJAPlayer3.t安全にDisposeする(Chara_GoGoTime);
            TJAPlayer3.t安全にDisposeする(Chara_GoGoTime_Maxed);
            TJAPlayer3.t安全にDisposeする(Chara_10Combo);
            TJAPlayer3.t安全にDisposeする(Chara_10Combo_Maxed);
            TJAPlayer3.t安全にDisposeする(Chara_GoGoStart);
            TJAPlayer3.t安全にDisposeする(Chara_GoGoStart_Maxed);
            TJAPlayer3.t安全にDisposeする(Chara_Become_Cleared);
            TJAPlayer3.t安全にDisposeする(Chara_Become_Maxed);
            TJAPlayer3.t安全にDisposeする(Chara_Balloon_Breaking);
            TJAPlayer3.t安全にDisposeする(Chara_Balloon_Broke);
            TJAPlayer3.t安全にDisposeする(Chara_Balloon_Miss);
            #endregion
            #region 踊り子
            for (int i = 0; i < Dancer.Length; i++)
            {
                TJAPlayer3.t安全にDisposeする(Dancer[i]);
            }
            #endregion
            #region モブ
            TJAPlayer3.t安全にDisposeする(Mob);
            #endregion
            #region フッター
            TJAPlayer3.t安全にDisposeする(ref Mob_Footer);
            #endregion
            #region 背景
            TJAPlayer3.t安全にDisposeする(ref Background);
            TJAPlayer3.t安全にDisposeする(Background_Up);
            TJAPlayer3.t安全にDisposeする(Background_Up_Clear);
            TJAPlayer3.t安全にDisposeする(ref Background_Down);
            TJAPlayer3.t安全にDisposeする(ref Background_Down_Clear);
            TJAPlayer3.t安全にDisposeする(ref Background_Down_Scroll);

            #endregion
            #region 太鼓
            TJAPlayer3.t安全にDisposeする(Taiko_Background);
            TJAPlayer3.t安全にDisposeする(Taiko_Frame);
            TJAPlayer3.t安全にDisposeする(Taiko_PlayerNumber);
            TJAPlayer3.t安全にDisposeする(Taiko_NamePlate);
            TJAPlayer3.t安全にDisposeする(ref Taiko_Base);
            TJAPlayer3.t安全にDisposeする(ref Taiko_Don_Left);
            TJAPlayer3.t安全にDisposeする(ref Taiko_Don_Right);
            TJAPlayer3.t安全にDisposeする(ref Taiko_Ka_Left);
            TJAPlayer3.t安全にDisposeする(ref Taiko_Ka_Right);
            TJAPlayer3.t安全にDisposeする(ref Taiko_LevelUp);
            TJAPlayer3.t安全にDisposeする(ref Taiko_LevelDown);
            TJAPlayer3.t安全にDisposeする(Course_Symbol);
            TJAPlayer3.t安全にDisposeする(Taiko_Score);
            TJAPlayer3.t安全にDisposeする(Taiko_Combo);
            TJAPlayer3.t安全にDisposeする(ref Taiko_Combo_Effect);
            TJAPlayer3.t安全にDisposeする(ref Taiko_Combo_Text);
            #endregion
            #region ゲージ
            TJAPlayer3.t安全にDisposeする(Gauge);
            TJAPlayer3.t安全にDisposeする(Gauge_Hard);
            TJAPlayer3.t安全にDisposeする(Gauge_Base);
            TJAPlayer3.t安全にDisposeする(Gauge_Base_Hard);
            TJAPlayer3.t安全にDisposeする(Gauge_Base_ExHard);
            TJAPlayer3.t安全にDisposeする(Gauge_Line);
            TJAPlayer3.t安全にDisposeする(Gauge_Line_Hard);
            TJAPlayer3.t安全にDisposeする(Gauge_Rainbow);
            TJAPlayer3.t安全にDisposeする(ref Gauge_Soul);
            TJAPlayer3.t安全にDisposeする(ref Gauge_Soul_Fire);
            TJAPlayer3.t安全にDisposeする(Gauge_Soul_Explosion);
            #endregion
            #region 吹き出し
            TJAPlayer3.t安全にDisposeする(Balloon_Combo);
            TJAPlayer3.t安全にDisposeする(ref Balloon_Roll);
            TJAPlayer3.t安全にDisposeする(ref Balloon_Balloon);
            TJAPlayer3.t安全にDisposeする(ref Balloon_Number_Roll);
            TJAPlayer3.t安全にDisposeする(ref Balloon_Number_Combo);
            TJAPlayer3.t安全にDisposeする(Balloon_Breaking);
            #endregion
            #region エフェクト
            TJAPlayer3.t安全にDisposeする(ref Effects_Hit_Explosion);
            TJAPlayer3.t安全にDisposeする(ref Effects_Hit_Explosion_Big);
            TJAPlayer3.t安全にDisposeする(ref Effects_Hit_FireWorks);

            TJAPlayer3.t安全にDisposeする(ref Effects_Fire);
            TJAPlayer3.t安全にDisposeする(ref Effects_Rainbow);

            TJAPlayer3.t安全にDisposeする(ref Effects_GoGoSplash);

            TJAPlayer3.t安全にDisposeする(Effects_Hit_Good);
            TJAPlayer3.t安全にDisposeする(Effects_Hit_Good_Big);
            TJAPlayer3.t安全にDisposeする(Effects_Hit_Great);
            TJAPlayer3.t安全にDisposeする(Effects_Hit_Great_Big);

            TJAPlayer3.t安全にDisposeする(Effects_Roll);
            #endregion
            #region レーン
            TJAPlayer3.t安全にDisposeする(Lane_Base);
            TJAPlayer3.t安全にDisposeする(Lane_Text);
            TJAPlayer3.t安全にDisposeする(ref Lane_Red);
            TJAPlayer3.t安全にDisposeする(ref Lane_Blue);
            TJAPlayer3.t安全にDisposeする(ref Lane_Yellow);
            TJAPlayer3.t安全にDisposeする(ref Lane_Background_Main);
            TJAPlayer3.t安全にDisposeする(ref Lane_Background_Sub);
            TJAPlayer3.t安全にDisposeする(ref Lane_Background_GoGo);

            #endregion
            #region 終了演出
            TJAPlayer3.t安全にDisposeする(End_Clear_L);
            TJAPlayer3.t安全にDisposeする(End_Clear_R);
            TJAPlayer3.t安全にDisposeする(ref End_Clear_Text);
            TJAPlayer3.t安全にDisposeする(ref End_Clear_Text_Effect);
            #endregion
            #region ゲームモード
            TJAPlayer3.t安全にDisposeする(ref GameMode_Timer_Tick);
            TJAPlayer3.t安全にDisposeする(ref GameMode_Timer_Frame);
            #endregion
            #region ステージ失敗
            TJAPlayer3.t安全にDisposeする(ref Failed_Game);
            TJAPlayer3.t安全にDisposeする(ref Failed_Stage);
            #endregion
            #region ランナー
            TJAPlayer3.t安全にDisposeする(ref Runner);
            #endregion
            #region DanC
            TJAPlayer3.t安全にDisposeする(ref DanC_Background);
            TJAPlayer3.t安全にDisposeする(DanC_Gauge);
            TJAPlayer3.t安全にDisposeする(ref DanC_Base);
            TJAPlayer3.t安全にDisposeする(ref DanC_Failed);
            TJAPlayer3.t安全にDisposeする(ref DanC_Number);
            TJAPlayer3.t安全にDisposeする(ref DanC_ExamRange);
            TJAPlayer3.t安全にDisposeする(ref DanC_ExamUnit);
            TJAPlayer3.t安全にDisposeする(ref DanC_ExamType);
            TJAPlayer3.t安全にDisposeする(ref DanC_Screen);
            #endregion
            #region PuchiChara
            TJAPlayer3.t安全にDisposeする(ref PuchiChara);
            #endregion
            #region Training
            TJAPlayer3.t安全にDisposeする(ref Tokkun_DownBG);
            TJAPlayer3.t安全にDisposeする(ref Tokkun_BigTaiko);
            TJAPlayer3.t安全にDisposeする(ref Tokkun_ProgressBar);
            TJAPlayer3.t安全にDisposeする(ref Tokkun_ProgressBarWhite);
            TJAPlayer3.t安全にDisposeする(ref Tokkun_GoGoPoint);
            TJAPlayer3.t安全にDisposeする(ref Tokkun_Background_Up);
            TJAPlayer3.t安全にDisposeする(ref Tokkun_BigNumber);
            TJAPlayer3.t安全にDisposeする(ref Tokkun_SmallNumber);
            #endregion
            #endregion

            #region 6_結果発表
            TJAPlayer3.t安全にDisposeする(ref Result_Background);
            TJAPlayer3.t安全にDisposeする(ref Result_FadeIn);
            TJAPlayer3.t安全にDisposeする(ref Result_Gauge);
            TJAPlayer3.t安全にDisposeする(ref Result_Gauge_Base);
            TJAPlayer3.t安全にDisposeする(ref Result_Gauge_Hard);
            TJAPlayer3.t安全にDisposeする(ref Result_Gauge_ExHard);
            TJAPlayer3.t安全にDisposeする(ref Result_Gauge_Base_Hard);
            TJAPlayer3.t安全にDisposeする(ref Result_Gauge_Base_ExHard);
            TJAPlayer3.t安全にDisposeする(ref Result_Judge);
            TJAPlayer3.t安全にDisposeする(ref Result_Header);
            TJAPlayer3.t安全にDisposeする(ref Result_Number);
            TJAPlayer3.t安全にDisposeする(ref Result_Panel);
            TJAPlayer3.t安全にDisposeする(ref Result_Score_Text);
            TJAPlayer3.t安全にDisposeする(ref Result_Score_Number);
            TJAPlayer3.t安全にDisposeする(ref Result_Dan);
            #endregion

            #region 7_終了画面
            TJAPlayer3.t安全にDisposeする(ref Exit_Background);
            #endregion

        }

        #region 共通
        public CTexture Tile_Black,
            Tile_White,
            Menu_Title,
            Menu_Highlight,
            Enum_Song,
            Scanning_Loudness,
            Overlay;
        public readonly CTexture[] NamePlate = new CTexture[2];
        #endregion
        #region 1_タイトル画面
        public CTexture Title_Background,
            Title_Menu;
        #endregion

        #region 2_コンフィグ画面
        public CTexture Config_Background,
            Config_Cursor,
            Config_ItemBox,
            Config_Arrow,
            Config_KeyAssign,
            Config_Font,
            Config_Font_Bold,
            Config_Enum_Song;
        #endregion

        #region 3_選曲画面
        public CTexture SongSelect_Background,
            SongSelect_Header,
            SongSelect_Footer,
            SongSelect_Difficulty,
            SongSelect_Auto,
            SongSelect_Level,
            SongSelect_Branch,
            SongSelect_Branch_Text,
            SongSelect_Frame_Score,
            SongSelect_Frame_BackBox,
            SongSelect_Frame_Random,
            SongSelect_Score_Select,
            SongSelect_Bar_Center,
            SongSelect_GenreText,
            SongSelect_Cursor_Left,
            SongSelect_Cursor_Right,
            SongSelect_ScoreWindow_Text,
            SongSelect_Rating;

        public readonly CTexture[] SongSelect_GenreBack = new CTexture[9];
        public readonly CTexture[] SongSelect_ScoreWindow = new CTexture[(int)Difficulty.Total];
        public readonly CTexture[] SongSelect_Bar_Genre = new CTexture[9];
        public readonly CTexture[] SongSelect_Frame_Box = new CTexture[9];

        #endregion

        #region 4_読み込み画面
        public CTexture SongLoading_Plate,
            SongLoading_FadeIn,
            SongLoading_FadeOut;
        #endregion

        #region 5_演奏画面
        #region 共通
        public CTexture Notes,
            Judge_Frame,
            SENotes,
            Notes_Arm,
            Judge;
        public CTexture Bar,
            Bar_Branch;
        #endregion
        #region キャラクター
        public CTexture[] Chara_Normal,
            Chara_Normal_Cleared,
            Chara_Normal_Maxed,
            Chara_GoGoTime,
            Chara_GoGoTime_Maxed,
            Chara_10Combo,
            Chara_10Combo_Maxed,
            Chara_GoGoStart,
            Chara_GoGoStart_Maxed,
            Chara_Become_Cleared,
            Chara_Become_Maxed,
            Chara_Balloon_Breaking,
            Chara_Balloon_Broke,
            Chara_Balloon_Miss;
        #endregion
        #region 踊り子
        public readonly CTexture[][] Dancer = new CTexture[5][];
        #endregion
        #region モブ
        public CTexture[] Mob;
        public CTexture Mob_Footer;
        #endregion
        #region 背景
        public CTexture Background,
            Background_Down,
            Background_Down_Clear,
            Background_Down_Scroll;
        public readonly CTexture[] Background_Up = new CTexture[2];
        public readonly CTexture[] Background_Up_Clear = new CTexture[2];

        #endregion
        #region 太鼓

        public readonly CTexture[] Taiko_Frame = new CTexture[2]; // MTaiko下敷き
        public readonly CTexture[] Taiko_Background = new CTexture[2];
        public CTexture Taiko_Base,
            Taiko_Don_Left,
            Taiko_Don_Right,
            Taiko_Ka_Left,
            Taiko_Ka_Right,
            Taiko_LevelUp,
            Taiko_LevelDown,
            Taiko_Combo_Effect,
            Taiko_Combo_Text;

        private static readonly string[] Course_Symbols = { "Easy", "Normal", "Hard", "Oni", "Edit", "Tower", "Dan", "Shin" };
        public readonly CTexture[] Course_Symbol = new CTexture[Course_Symbols.Length];
        public readonly CTexture[] Taiko_PlayerNumber = new CTexture[2];
        public readonly CTexture[] Taiko_NamePlate = new CTexture[2]; // ネームプレート
        public readonly CTexture[] Taiko_Score = new CTexture[3];
        public readonly CTexture[] Taiko_Combo = new CTexture[2];
        #endregion
        #region ゲージ
        public readonly CTexture[] Gauge = new CTexture[2];
        public readonly CTexture[] Gauge_Hard = new CTexture[2];
        public readonly CTexture[] Gauge_ExHard = new CTexture[2];
        public readonly CTexture[] Gauge_Base = new CTexture[2];
        public readonly CTexture[] Gauge_Base_Hard = new CTexture[2];
        public readonly CTexture[] Gauge_Base_ExHard = new CTexture[2];
        public readonly CTexture[] Gauge_Line = new CTexture[2];
        public readonly CTexture[] Gauge_Line_Hard = new CTexture[2];
        public CTexture[] Gauge_Rainbow;
        public readonly CTexture[] Gauge_Soul_Explosion = new CTexture[2];

        public CTexture Gauge_Soul,
            Gauge_Soul_Fire;
        #endregion
        #region 吹き出し
        public readonly CTexture[] Balloon_Combo = new CTexture[2];
        public CTexture Balloon_Roll,
            Balloon_Balloon,
            Balloon_Number_Roll,
            Balloon_Number_Combo/*,*/
                                /*Balloon_Broken*/;
        public readonly CTexture[] Balloon_Breaking = new CTexture[6];
        #endregion
        #region エフェクト
        public CTexture Effects_Hit_Explosion,
            Effects_Hit_Explosion_Big,
            Effects_Fire,
            Effects_Rainbow,
            Effects_GoGoSplash,
            Effects_Hit_FireWorks;

        public readonly CTexture[] Effects_Hit_Good = new CTexture[15];
        public readonly CTexture[] Effects_Hit_Good_Big = new CTexture[15];
        public readonly CTexture[] Effects_Hit_Great = new CTexture[15];
        public readonly CTexture[] Effects_Hit_Great_Big = new CTexture[15];

        public CTexture[] Effects_Roll;
        #endregion
        #region レーン
        public readonly CTexture[] Lane_Base = new CTexture[3];
        public readonly CTexture[] Lane_Text = new CTexture[3];

        public CTexture Lane_Red,
            Lane_Blue,
            Lane_Yellow;
        public CTexture Lane_Background_Main,
            Lane_Background_Sub,
            Lane_Background_GoGo;
        #endregion
        #region 終了演出
        public readonly CTexture[] End_Clear_L = new CTexture[5];
        public readonly CTexture[] End_Clear_R = new CTexture[5];

        public CTexture End_Clear_Text,
            End_Clear_Text_Effect;
        #endregion
        #region ゲームモード
        public CTexture GameMode_Timer_Frame,
            GameMode_Timer_Tick;
        #endregion
        #region ステージ失敗
        public CTexture Failed_Game,
            Failed_Stage;
        #endregion
        #region ランナー
        public CTexture Runner;
        #endregion
        #region DanC
        public CTexture DanC_Background;
        public CTexture[] DanC_Gauge;
        public CTexture DanC_Base;
        public CTexture DanC_Failed;
        public CTexture DanC_Number,
            DanC_ExamType,
            DanC_ExamRange,
            DanC_ExamUnit;
        public CTexture DanC_Screen;
        #endregion
        #region PuchiChara
        public CTexture PuchiChara;
        #endregion
        #region Training
        public CTexture Tokkun_DownBG;
        public CTexture Tokkun_BigTaiko;
        public CTexture Tokkun_ProgressBar;
        public CTexture Tokkun_ProgressBarWhite;
        public CTexture Tokkun_GoGoPoint;
        public CTexture Tokkun_Background_Up;
        public CTexture Tokkun_BigNumber;
        public CTexture Tokkun_SmallNumber;
        #endregion
        #endregion

        #region 6_結果発表
        public CTexture Result_Background,
            Result_FadeIn,
            Result_Gauge,
            Result_Gauge_Hard,
            Result_Gauge_ExHard,
            Result_Gauge_Base,
            Result_Gauge_Base_Hard,
            Result_Gauge_Base_ExHard,
            Result_Judge,
            Result_Header,
            Result_Number,
            Result_Panel,
            Result_Score_Text,
            Result_Score_Number,
            Result_Dan;
        #endregion

        #region 7_終了画面
        public CTexture Exit_Background/* , */
                                       /*Exit_Text */;
        #endregion

    }
}
