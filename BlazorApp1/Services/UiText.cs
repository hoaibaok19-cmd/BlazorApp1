namespace BlazorApp1.Services;

/// <summary>
/// Interface labels (buttons, headings…) in English and Vietnamese.
/// Shared labels live in <see cref="Base"/>; labels whose wording changes with the
/// active persona are overridden in <see cref="Overrides"/>. Personal content lives
/// in wwwroot/data/portfolio.{persona}.json.
/// </summary>
public static class UiText
{
    private static readonly Dictionary<string, (string En, string Vi)> Base = new()
    {
        ["nav.home"] = ("Home", "Trang chủ"),
        ["nav.about"] = ("About", "Giới thiệu"),
        ["nav.experience"] = ("Experience", "Kinh nghiệm"),
        ["nav.contact"] = ("Contact", "Liên hệ"),
        ["nav.primary"] = ("Main navigation", "Điều hướng chính"),
        ["nav.skip"] = ("Skip to content", "Bỏ qua đến nội dung"),
        ["nav.open"] = ("Open menu", "Mở menu"),
        ["nav.close"] = ("Close menu", "Đóng menu"),
        ["lang.switch"] = ("Chuyển sang tiếng Việt", "Switch to English"),
        ["theme.light"] = ("Switch to light theme", "Chuyển sang giao diện sáng"),
        ["theme.dark"] = ("Switch to dark theme", "Chuyển sang giao diện tối"),
        ["social"] = ("Social links", "Mạng xã hội"),

        ["hero.contact"] = ("Get in touch", "Liên hệ"),
        ["hero.cv"] = ("Download CV", "Tải CV"),
        ["hero.scroll"] = ("Scroll down", "Cuộn xuống"),

        ["skills.level.expert"] = ("Expert", "Chuyên sâu"),
        ["skills.level.advanced"] = ("Advanced", "Nâng cao"),
        ["skills.level.intermediate"] = ("Intermediate", "Khá"),
        ["skills.level.familiar"] = ("Familiar", "Cơ bản"),

        ["experience.work"] = ("Work", "Công việc"),
        ["experience.education"] = ("Education", "Học vấn"),

        ["gallery.all"] = ("All", "Tất cả"),
        ["gallery.filter"] = ("Filter photos", "Lọc ảnh"),
        ["gallery.view"] = ("View photo", "Xem ảnh"),
        ["gallery.viewer"] = ("Image viewer", "Trình xem ảnh"),
        ["gallery.close"] = ("Close", "Đóng"),
        ["gallery.prev"] = ("Previous photo", "Ảnh trước"),
        ["gallery.next"] = ("Next photo", "Ảnh sau"),

        ["projects.all"] = ("All", "Tất cả"),
        ["projects.filter"] = ("Filter projects", "Lọc dự án"),
        ["projects.featured"] = ("Featured", "Nổi bật"),
        ["projects.tech"] = ("Tools & standards", "Công cụ & tiêu chuẩn"),
        ["projects.highlights"] = ("Highlights", "Điểm nổi bật"),
        ["projects.details"] = ("Details", "Chi tiết"),
        ["projects.code"] = ("Source", "Mã nguồn"),
        ["projects.demo"] = ("Live demo", "Xem thử"),
        ["projects.close"] = ("Close", "Đóng"),

        ["contact.email"] = ("Email", "Email"),
        ["contact.phone"] = ("Phone", "Điện thoại"),
        ["contact.location"] = ("Location", "Địa điểm"),
        ["contact.copy"] = ("Copy email address", "Sao chép địa chỉ email"),
        ["contact.copied"] = ("Copied!", "Đã sao chép!"),
        ["contact.form.title"] = ("Send me a message", "Gửi lời nhắn cho tôi"),
        ["contact.form.name"] = ("Your name", "Họ và tên"),
        ["contact.form.email"] = ("Your email", "Email của bạn"),
        ["contact.form.message"] = ("Message", "Lời nhắn"),
        ["contact.form.namePlaceholder"] = ("Jane Doe", "Nguyễn Văn A"),
        ["contact.form.messagePlaceholder"] = ("Write your message here…", "Viết lời nhắn của bạn ở đây…"),
        ["contact.form.send"] = ("Send message", "Gửi lời nhắn"),
        ["contact.form.sending"] = ("Sending…", "Đang gửi…"),
        ["contact.form.sent"] = ("Thank you! Your message has been sent.", "Cảm ơn bạn! Lời nhắn đã được gửi."),
        ["contact.form.opened"] = ("Opening your email app…", "Đang mở ứng dụng email của bạn…"),
        ["contact.form.error"] = ("Something went wrong. Please email me directly.", "Đã có lỗi xảy ra. Vui lòng gửi email trực tiếp cho tôi."),
        ["contact.form.required"] = ("Please fill in every field.", "Vui lòng điền đầy đủ các trường."),
        ["contact.form.invalidEmail"] = ("Please enter a valid email address.", "Vui lòng nhập địa chỉ email hợp lệ."),
        ["contact.form.mailtoNote"] = ("Your email app will open with the message pre-filled.", "Ứng dụng email sẽ mở với nội dung đã được điền sẵn."),

        ["footer.rights"] = ("All rights reserved.", "Bảo lưu mọi quyền."),
        ["footer.built"] = ("Built with Blazor WebAssembly · Hosted on GitHub Pages", "Xây dựng bằng Blazor WebAssembly · Triển khai trên GitHub Pages"),
        ["footer.top"] = ("Back to top", "Lên đầu trang"),

        ["notfound.title"] = ("Page not found", "Không tìm thấy trang"),
        ["notfound.text"] = ("The page you're looking for doesn't exist or has been moved.", "Trang bạn đang tìm không tồn tại hoặc đã được di chuyển."),
        ["notfound.home"] = ("Back to home", "Về trang chủ"),

        ["error.title"] = ("Couldn't load the portfolio content", "Không thể tải nội dung portfolio"),
        ["error.text"] = ("Check that the portfolio JSON file exists and contains valid JSON.", "Hãy kiểm tra file portfolio JSON có tồn tại và đúng định dạng JSON."),
        ["error.reload"] = ("Reload", "Tải lại"),

        // Persona chooser (landing page)
        ["chooser.title"] = ("Choose a portfolio", "Chọn một hồ sơ"),
        ["chooser.subtitle"] = ("I work across three worlds — pick one to explore.", "Tôi hoạt động trong ba lĩnh vực — chọn một để khám phá."),
        ["chooser.hint"] = ("You can switch anytime from the top bar.", "Bạn có thể chuyển đổi bất cứ lúc nào ở thanh trên cùng."),
        ["chooser.enter"] = ("Enter", "Vào xem"),
        ["persona.switch"] = ("Switch portfolio", "Đổi hồ sơ"),
        ["persona.back"] = ("Back to chooser", "Về trang chọn"),

        ["chooser.bim.name"] = ("BIM", "BIM"),
        ["chooser.bim.role"] = ("BIM Modeler", "BIM Modeler"),
        ["chooser.bim.desc"] = ("3D modelling, coordination and automation for construction.", "Dựng mô hình 3D, phối hợp và tự động hóa cho xây dựng."),

        ["chooser.trekking.name"] = ("Trekking", "Trekking"),
        ["chooser.trekking.role"] = ("Trekking Guide", "Hướng dẫn viên trekking"),
        ["chooser.trekking.desc"] = ("Guided treks and mountain adventures across Vietnam.", "Dẫn tour trekking và chinh phục núi rừng Việt Nam."),

        ["chooser.photography.name"] = ("Photography", "Nhiếp ảnh"),
        ["chooser.photography.role"] = ("Photographer", "Nhiếp ảnh gia"),
        ["chooser.photography.desc"] = ("Portraits, weddings, street and landscape stories.", "Chân dung, ảnh cưới, đời thường và phong cảnh."),
    };

    private static readonly Dictionary<string, Dictionary<string, (string En, string Vi)>> Overrides = new()
    {
        ["bim"] = new()
        {
            ["nav.projects"] = ("Projects", "Dự án"),
            ["nav.skills"] = ("Skills", "Kỹ năng"),

            ["hero.greeting"] = ("BIM Modeler", "BIM Modeler"),
            ["hero.viewWork"] = ("View projects", "Xem dự án"),

            ["about.title"] = ("About me", "Về tôi"),
            ["about.subtitle"] = ("A quick introduction to who I am and how I work.", "Đôi nét về tôi và cách tôi làm việc."),

            ["skills.title"] = ("Skills & tools", "Kỹ năng & công cụ"),
            ["skills.subtitle"] = ("The software, standards and workflows I use to deliver coordinated BIM models.", "Phần mềm, tiêu chuẩn và quy trình tôi dùng để tạo ra những mô hình BIM được phối hợp chặt chẽ."),
            ["skills.toolbox"] = ("Also in my toolbox", "Công cụ khác tôi dùng"),

            ["experience.title"] = ("Experience & education", "Kinh nghiệm & học vấn"),
            ["experience.subtitle"] = ("Where I've worked and what I studied.", "Nơi tôi đã làm việc và quá trình học tập của tôi."),

            ["projects.title"] = ("Selected projects", "Dự án tiêu biểu"),
            ["projects.subtitle"] = ("A selection of BIM, coordination and automation work I've contributed to.", "Một số dự án BIM, phối hợp mô hình và tự động hóa mà tôi đã tham gia."),

            ["contact.title"] = ("Let's build something together", "Cùng nhau xây dựng"),
            ["contact.subtitle"] = ("Need help with BIM modelling, coordination or automation? Let's talk.", "Bạn cần hỗ trợ về dựng mô hình, phối hợp hay tự động hóa BIM? Hãy trao đổi với tôi."),
        },

        ["trekking"] = new()
        {
            ["nav.gallery"] = ("Tours", "Hành trình"),
            ["nav.skills"] = ("Services", "Dịch vụ"),

            ["hero.greeting"] = ("Trekking Guide", "Hướng dẫn viên trekking"),
            ["hero.viewWork"] = ("Explore tours", "Khám phá hành trình"),

            ["about.title"] = ("Your guide on the trail", "Người bạn đồng hành trên mỗi cung đường"),
            ["about.subtitle"] = ("Who I am and why I love leading people into the mountains.", "Tôi là ai và vì sao tôi yêu thích dẫn mọi người vào những chuyến đi giữa núi rừng."),

            ["skills.title"] = ("What I offer", "Dịch vụ của tôi"),
            ["skills.subtitle"] = ("From day hikes to multi-day expeditions — guided treks tailored to you.", "Từ chuyến đi trong ngày đến hành trình nhiều ngày — những cung trek được thiết kế riêng cho bạn."),
            ["skills.toolbox"] = ("Always in my pack", "Luôn có trong balo"),

            ["experience.title"] = ("On the trail so far", "Hành trình đã qua"),
            ["experience.subtitle"] = ("Expeditions I've led and the training behind them.", "Những chuyến đi tôi đã dẫn và quá trình rèn luyện phía sau."),

            ["gallery.title"] = ("Featured treks", "Cung đường nổi bật"),
            ["gallery.subtitle"] = ("A collection of trails and summits — tap any photo to view it full-size.", "Bộ sưu tập những cung đường và đỉnh núi — chạm vào ảnh để xem ở kích thước đầy đủ."),
            ["gallery.filter"] = ("Filter treks", "Lọc hành trình"),

            ["contact.title"] = ("Ready for your next adventure?", "Sẵn sàng cho hành trình tiếp theo?"),
            ["contact.subtitle"] = ("Planning a trek or want a custom route? Send me a message.", "Bạn muốn lên kế hoạch cho một chuyến trek hoặc cần cung đường riêng? Hãy nhắn cho tôi."),
        },

        ["photography"] = new()
        {
            ["nav.gallery"] = ("Gallery", "Thư viện"),
            ["nav.skills"] = ("Services", "Dịch vụ"),

            ["hero.greeting"] = ("Photographer", "Nhiếp ảnh gia"),
            ["hero.viewWork"] = ("View gallery", "Xem thư viện"),

            ["about.title"] = ("Behind the lens", "Phía sau ống kính"),
            ["about.subtitle"] = ("Who I am, how I see light and what I love to photograph.", "Tôi là ai, tôi cảm nhận ánh sáng ra sao và tôi yêu thích chụp điều gì."),

            ["skills.title"] = ("What I offer", "Dịch vụ của tôi"),
            ["skills.subtitle"] = ("From the first shutter click to the final edit — here's how I can help tell your story.", "Từ cú bấm máy đầu tiên đến khâu hậu kỳ cuối cùng — đây là cách tôi giúp kể câu chuyện của bạn."),
            ["skills.toolbox"] = ("In my camera bag", "Thiết bị trong túi máy"),

            ["experience.title"] = ("My journey so far", "Hành trình của tôi"),
            ["experience.subtitle"] = ("Exhibitions, collaborations and studies that shaped my eye.", "Những triển lãm, dự án hợp tác và quá trình học tập đã rèn giũa con mắt của tôi."),

            ["gallery.title"] = ("Selected work", "Tuyển tập ảnh"),
            ["gallery.subtitle"] = ("A living collection of frames — portraits, weddings, streets and landscapes. Tap any photo to view it full-size.", "Bộ sưu tập những khoảnh khắc — chân dung, ảnh cưới, đời thường và phong cảnh. Chạm vào ảnh để xem ở kích thước đầy đủ."),

            ["contact.title"] = ("Let's create something beautiful", "Cùng tạo nên điều đẹp đẽ"),
            ["contact.subtitle"] = ("Booking a session, planning a shoot or just want to say hello? I'd love to hear from you.", "Bạn muốn đặt lịch chụp, lên kế hoạch cho buổi chụp hay chỉ muốn chào hỏi? Rất mong được nghe từ bạn."),
        },
    };

    public static string Get(string key, string language, string? persona = null)
    {
        if (persona is not null
            && Overrides.TryGetValue(persona, out var overrides)
            && overrides.TryGetValue(key, out var overridden))
        {
            return language == "vi" ? overridden.Vi : overridden.En;
        }

        return Base.TryGetValue(key, out var text) ? (language == "vi" ? text.Vi : text.En) : key;
    }
}
