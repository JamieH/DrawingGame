$(function () {

    var ctx = document.getElementById("canvas").getContext("2d"),
        canvas = document.getElementById("canvas"),
        $cvs = $("#canvas"),
        img, top = $cvs.offset().top,
        left = $cvs.offset().left,
        draw = 0

    var resizeCvs = function () {
        ctx.canvas.width = $(window).width();
        ctx.canvas.height = $(window).height();
    };

    var getImage = function ()
    {
        var img = canvas.toDataURL("image/png");
    }

    var initializeCvs = function (clearing) {
        var mnu = $(".menu")[0];
        ctx.lineCap = "round";
        resizeCvs();
        ctx.lineWidth = 12;
        ctx.save();
        ctx.fillStyle = '#ffffff';
        ctx.fillRect(0, 0, ctx.canvas.width, ctx.canvas.height);
        ctx.restore();
    };
    ctx.fillCircle = function(x, y, radius) {
            this.moveTo(x, y);
            this.arc(x, y, radius, 0, Math.PI * 2, false);
            this.fill();
    };

    $cvs.mousedown(function (e) {
        if (e.button === 0) {
            draw = 1;
            ctx.beginPath();
            ctx.moveTo(e.pageX - left, e.pageY - top);
            ctx.fillCircle(e.pageX - left, e.pageY - top, 2);
        } else {
            draw = 0;
        }
    })
        .mouseup(function (e) {
            if (e.button === 0) {
                draw = 0;
                ctx.lineTo(e.pageX - left + 1, e.pageY - top + 1);
                ctx.fillCircle(e.pageX - left + 1, e.pageY - top + 1, 2);
                ctx.stroke();
                ctx.closePath();

            } else {
                draw = 1;
            }
        })
        .mousemove(function (e) {
            if (draw === 1) {
                ctx.lineTo(e.pageX - left + 1, e.pageY - top + 1);
                ctx.stroke();
                ctx.fillCircle(e.pageX - left, e.pageY - top, 2);
            }
        });

    $('#clear').click(function (e) {
        initializeCvs(true);
    });
    initializeCvs();
});