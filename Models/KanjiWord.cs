namespace JapLearn.Models;

public class KanjiWord
{
    public string Kanji { get; set; } = "";
    public string Hiragana { get; set; } = "";
    public string Meaning { get; set; } = "";
    public string JLPT { get; set; } = "";

    public static List<KanjiWord> All = new()
    {
        // Numbers
        new() { Kanji = "一", Hiragana = "いち", Meaning = "một", JLPT = "N5" },
        new() { Kanji = "二", Hiragana = "に", Meaning = "hai", JLPT = "N5" },
        new() { Kanji = "三", Hiragana = "さん", Meaning = "ba", JLPT = "N5" },
        new() { Kanji = "四", Hiragana = "し/よん", Meaning = "bốn", JLPT = "N5" },
        new() { Kanji = "五", Hiragana = "ご", Meaning = "năm", JLPT = "N5" },
        new() { Kanji = "六", Hiragana = "ろく", Meaning = "sáu", JLPT = "N5" },
        new() { Kanji = "七", Hiragana = "しち/なな", Meaning = "bảy", JLPT = "N5" },
        new() { Kanji = "八", Hiragana = "はち", Meaning = "tám", JLPT = "N5" },
        new() { Kanji = "九", Hiragana = "く/きゅう", Meaning = "chín", JLPT = "N5" },
        new() { Kanji = "十", Hiragana = "じゅう", Meaning = "mười", JLPT = "N5" },
        new() { Kanji = "百", Hiragana = "ひゃく", Meaning = "trăm", JLPT = "N5" },
        new() { Kanji = "千", Hiragana = "せん", Meaning = "ngàn", JLPT = "N5" },
        new() { Kanji = "万", Hiragana = "まん", Meaning = "vạn", JLPT = "N5" },

        // Days / Time
        new() { Kanji = "日", Hiragana = "にち", Meaning = "ngày, mặt trời", JLPT = "N5" },
        new() { Kanji = "月", Hiragana = "げつ", Meaning = "tháng, mặt trăng", JLPT = "N5" },
        new() { Kanji = "火", Hiragana = "か", Meaning = "lửa", JLPT = "N5" },
        new() { Kanji = "木", Hiragana = "もく", Meaning = "gỗ, cây", JLPT = "N5" },
        new() { Kanji = "金", Hiragana = "きん", Meaning = "vàng, kim loại", JLPT = "N5" },
        new() { Kanji = "土", Hiragana = "ど", Meaning = "đất", JLPT = "N5" },
        new() { Kanji = "年", Hiragana = "ねん", Meaning = "năm", JLPT = "N5" },
        new() { Kanji = "時", Hiragana = "じ", Meaning = "giờ", JLPT = "N5" },
        new() { Kanji = "間", Hiragana = "かん", Meaning = "khoảng thời gian", JLPT = "N5" },
        new() { Kanji = "今", Hiragana = "こん", Meaning = "bây giờ, hiện tại", JLPT = "N5" },
        new() { Kanji = "毎", Hiragana = "まい", Meaning = "mỗi", JLPT = "N5" },
        new() { Kanji = "先", Hiragana = "せん", Meaning = "trước", JLPT = "N5" },
        new() { Kanji = "来", Hiragana = "らい", Meaning = "đến, sau", JLPT = "N5" },
        new() { Kanji = "午", Hiragana = "ご", Meaning = "trưa, ngọ", JLPT = "N5" },
        new() { Kanji = "前", Hiragana = "ぜん", Meaning = "trước", JLPT = "N5" },
        new() { Kanji = "後", Hiragana = "ご", Meaning = "sau", JLPT = "N5" },

        // People / Family
        new() { Kanji = "人", Hiragana = "じん/ひと", Meaning = "người", JLPT = "N5" },
        new() { Kanji = "男", Hiragana = "だん/おとこ", Meaning = "nam, đàn ông", JLPT = "N5" },
        new() { Kanji = "女", Hiragana = "じょ/おんな", Meaning = "nữ, phụ nữ", JLPT = "N5" },
        new() { Kanji = "子", Hiragana = "し/こ", Meaning = "con, trẻ em", JLPT = "N5" },
        new() { Kanji = "父", Hiragana = "ちち", Meaning = "cha", JLPT = "N5" },
        new() { Kanji = "母", Hiragana = "はは", Meaning = "mẹ", JLPT = "N5" },
        new() { Kanji = "兄", Hiragana = "あに", Meaning = "anh trai", JLPT = "N5" },
        new() { Kanji = "姉", Hiragana = "あね", Meaning = "chị gái", JLPT = "N5" },
        new() { Kanji = "弟", Hiragana = "おとうと", Meaning = "em trai", JLPT = "N5" },
        new() { Kanji = "妹", Hiragana = "いもうと", Meaning = "em gái", JLPT = "N5" },
        new() { Kanji = "友", Hiragana = "とも", Meaning = "bạn bè", JLPT = "N5" },
        new() { Kanji = "先生", Hiragana = "せんせい", Meaning = "giáo viên", JLPT = "N5" },
        new() { Kanji = "学生", Hiragana = "がくせい", Meaning = "học sinh", JLPT = "N5" },

        // School / Study
        new() { Kanji = "学", Hiragana = "がく", Meaning = "học", JLPT = "N5" },
        new() { Kanji = "校", Hiragana = "こう", Meaning = "trường", JLPT = "N5" },
        new() { Kanji = "本", Hiragana = "ほん", Meaning = "sách", JLPT = "N5" },
        new() { Kanji = "文", Hiragana = "ぶん", Meaning = "văn bản", JLPT = "N5" },
        new() { Kanji = "字", Hiragana = "じ", Meaning = "chữ", JLPT = "N5" },
        new() { Kanji = "語", Hiragana = "ご", Meaning = "ngôn ngữ", JLPT = "N5" },
        new() { Kanji = "国", Hiragana = "こく", Meaning = "đất nước", JLPT = "N5" },
        new() { Kanji = "外", Hiragana = "がい", Meaning = "ngoài", JLPT = "N5" },

        // Food / Drink
        new() { Kanji = "食", Hiragana = "しょく/た", Meaning = "ăn, thức ăn", JLPT = "N5" },
        new() { Kanji = "飲", Hiragana = "いん/の", Meaning = "uống", JLPT = "N5" },
        new() { Kanji = "水", Hiragana = "みず", Meaning = "nước", JLPT = "N5" },
        new() { Kanji = "茶", Hiragana = "ちゃ", Meaning = "trà", JLPT = "N5" },
        new() { Kanji = "肉", Hiragana = "にく", Meaning = "thịt", JLPT = "N5" },
        new() { Kanji = "魚", Hiragana = "さかな/ぎょ", Meaning = "cá", JLPT = "N5" },
        new() { Kanji = "野菜", Hiragana = "やさい", Meaning = "rau", JLPT = "N5" },
        new() { Kanji = "果物", Hiragana = "くだもの", Meaning = "trái cây", JLPT = "N5" },
        new() { Kanji = "牛乳", Hiragana = "ぎゅうにゅう", Meaning = "sữa bò", JLPT = "N5" },

        // Places / Directions
        new() { Kanji = "上", Hiragana = "うえ", Meaning = "trên", JLPT = "N5" },
        new() { Kanji = "下", Hiragana = "した", Meaning = "dưới", JLPT = "N5" },
        new() { Kanji = "左", Hiragana = "ひだり", Meaning = "trái", JLPT = "N5" },
        new() { Kanji = "右", Hiragana = "みぎ", Meaning = "phải", JLPT = "N5" },
        new() { Kanji = "中", Hiragana = "ちゅう/なか", Meaning = "giữa, trong", JLPT = "N5" },
        new() { Kanji = "長", Hiragana = "なが", Meaning = "dài", JLPT = "N5" },
        new() { Kanji = "円", Hiragana = "えん", Meaning = "yên (tiền)", JLPT = "N5" },
        new() { Kanji = "店", Hiragana = "みせ/てん", Meaning = "cửa hàng", JLPT = "N5" },
        new() { Kanji = "学校", Hiragana = "がっこう", Meaning = "trường học", JLPT = "N5" },
        new() { Kanji = "病院", Hiragana = "びょういん", Meaning = "bệnh viện", JLPT = "N5" },

        // Nature / Weather
        new() { Kanji = "天", Hiragana = "てん", Meaning = "trời", JLPT = "N5" },
        new() { Kanji = "気", Hiragana = "き/け", Meaning = "không khí, tinh thần", JLPT = "N5" },
        new() { Kanji = "雨", Hiragana = "あめ", Meaning = "mưa", JLPT = "N5" },
        new() { Kanji = "雪", Hiragana = "ゆき", Meaning = "tuyết", JLPT = "N5" },
        new() { Kanji = "花", Hiragana = "はな", Meaning = "hoa", JLPT = "N5" },
        new() { Kanji = "山", Hiragana = "やま/さん", Meaning = "núi", JLPT = "N5" },
        new() { Kanji = "川", Hiragana = "かわ", Meaning = "sông", JLPT = "N5" },
        new() { Kanji = "海", Hiragana = "うみ/かい", Meaning = "biển", JLPT = "N5" },
        new() { Kanji = "空", Hiragana = "そら/くう", Meaning = "bầu trời", JLPT = "N5" },

        // Verbs
        new() { Kanji = "見る", Hiragana = "みる", Meaning = "xem", JLPT = "N5" },
        new() { Kanji = "聞く", Hiragana = "きく", Meaning = "nghe", JLPT = "N5" },
        new() { Kanji = "話す", Hiragana = "はなす", Meaning = "nói chuyện", JLPT = "N5" },
        new() { Kanji = "読む", Hiragana = "よむ", Meaning = "đọc", JLPT = "N5" },
        new() { Kanji = "書く", Hiragana = "かく", Meaning = "viết", JLPT = "N5" },
        new() { Kanji = "買う", Hiragana = "かう", Meaning = "mua", JLPT = "N5" },
        new() { Kanji = "売る", Hiragana = "うる", Meaning = "bán", JLPT = "N5" },
        new() { Kanji = "食べる", Hiragana = "たべる", Meaning = "ăn", JLPT = "N5" },
        new() { Kanji = "飲む", Hiragana = "のむ", Meaning = "uống", JLPT = "N5" },
        new() { Kanji = "行く", Hiragana = "いく", Meaning = "đi", JLPT = "N5" },
        new() { Kanji = "来る", Hiragana = "くる", Meaning = "đến", JLPT = "N5" },
        new() { Kanji = "帰る", Hiragana = "かえる", Meaning = "về", JLPT = "N5" },
        new() { Kanji = "寝る", Hiragana = "ねる", Meaning = "ngủ", JLPT = "N5" },
        new() { Kanji = "起きる", Hiragana = "おきる", Meaning = "thức dậy", JLPT = "N5" },
        new() { Kanji = "勉強", Hiragana = "べんきょう", Meaning = "học bài", JLPT = "N5" },
        new() { Kanji = "働く", Hiragana = "はたらく", Meaning = "làm việc", JLPT = "N5" },
        new() { Kanji = "休む", Hiragana = "やすむ", Meaning = "nghỉ ngơi", JLPT = "N5" },
        new() { Kanji = "立つ", Hiragana = "たつ", Meaning = "đứng", JLPT = "N5" },
        new() { Kanji = "座る", Hiragana = "すわる", Meaning = "ngồi", JLPT = "N5" },

        // Adjectives (i-adjectives)
        new() { Kanji = "大", Hiragana = "おおきい", Meaning = "to lớn", JLPT = "N5" },
        new() { Kanji = "小", Hiragana = "ちいさい", Meaning = "nhỏ bé", JLPT = "N5" },
        new() { Kanji = "高", Hiragana = "たかい", Meaning = "cao, đắt", JLPT = "N5" },
        new() { Kanji = "安", Hiragana = "やすい", Meaning = "rẻ", JLPT = "N5" },
        new() { Kanji = "新", Hiragana = "あたらしい", Meaning = "mới", JLPT = "N5" },
        new() { Kanji = "古", Hiragana = "ふるい", Meaning = "cũ", JLPT = "N5" },
        new() { Kanji = "早", Hiragana = "はやい", Meaning = "sớm, nhanh", JLPT = "N5" },
        new() { Kanji = "白", Hiragana = "しろい", Meaning = "trắng", JLPT = "N5" },
        new() { Kanji = "黒", Hiragana = "くろい", Meaning = "đen", JLPT = "N5" },
        new() { Kanji = "赤", Hiragana = "あかい/あか", Meaning = "đỏ, màu đỏ", JLPT = "N5" },
        new() { Kanji = "青", Hiragana = "あおい/あお", Meaning = "xanh, màu xanh", JLPT = "N5" },

        // Miscellaneous
        new() { Kanji = "名", Hiragana = "な/めい", Meaning = "tên", JLPT = "N5" },
        new() { Kanji = "何", Hiragana = "なに", Meaning = "cái gì", JLPT = "N5" },
        new() { Kanji = "電", Hiragana = "でん", Meaning = "điện", JLPT = "N5" },
        new() { Kanji = "車", Hiragana = "くるま/しゃ", Meaning = "xe", JLPT = "N5" },
        new() { Kanji = "駅", Hiragana = "えき", Meaning = "nhà ga", JLPT = "N5" },
        new() { Kanji = "道", Hiragana = "みち/どう", Meaning = "đường", JLPT = "N5" },
        new() { Kanji = "毎日", Hiragana = "まいにち", Meaning = "mỗi ngày", JLPT = "N5" },
        new() { Kanji = "毎週", Hiragana = "まいしゅう", Meaning = "mỗi tuần", JLPT = "N5" },
        new() { Kanji = "毎年", Hiragana = "まいとし", Meaning = "mỗi năm", JLPT = "N5" },
        new() { Kanji = "今日", Hiragana = "きょう", Meaning = "hôm nay", JLPT = "N5" },
        new() { Kanji = "明日", Hiragana = "あした", Meaning = "ngày mai", JLPT = "N5" },
        new() { Kanji = "昨日", Hiragana = "きのう", Meaning = "hôm qua", JLPT = "N5" },
        new() { Kanji = "天気", Hiragana = "てんき", Meaning = "thời tiết", JLPT = "N5" },
        new() { Kanji = "電気", Hiragana = "でんき", Meaning = "điện, đèn", JLPT = "N5" },
        new() { Kanji = "電話", Hiragana = "でんわ", Meaning = "điện thoại", JLPT = "N5" },
        new() { Kanji = "上手", Hiragana = "じょうず", Meaning = "giỏi", JLPT = "N5" },
        new() { Kanji = "下手", Hiragana = "へた", Meaning = "kém", JLPT = "N5" },
    };
}