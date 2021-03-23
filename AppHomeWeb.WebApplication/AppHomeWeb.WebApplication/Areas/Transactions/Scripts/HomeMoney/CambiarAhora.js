(function ($, undefined) {
    'use strict';
    var Form = function ($element, options) {
        $.extend(this, $.fn.ContenedorCambiarAhora.defaults, $element.data(), typeof options == 'object' && options);
        this.setControls({
            form: $element,
            hdidPerfilUsuario: $('#hdidPerfilUsuario', $element)
        });
    };
    Form.prototype = {
        constructor: Form,
        init: function () {
            var that = this,
            controls = that.getControls();
            console.log('CambiarAhora');
            that.render();
        },
        render: function () {
            var that = this,
                controls = that.getControls();            
        },      
        getControls: function () {
            return this.m_controls || {};
        },
        setControls: function (value) {
            this.m_controls = value;
        },
        strUrl: window.location.protocol + '//' + window.location.host
    };
    $.fn.ContenedorCambiarAhora = function () {
        var option = arguments[0],
            args = arguments,
            value,
            allowedMethods = [];

        this.each(function () {

            var $this = $(this),
                data = $this.data('ContenedorCambiarAhora'),
                options = $.extend({}, $.fn.ContenedorCambiarAhora.defaults,
                    $this.data(), typeof option === 'object' && option);

            if (!data) {
                data = new Form($this, options);
                $this.data('RecordEquipment', data);
            }

            if (typeof option === 'string') {
                if ($.inArray(option, allowedMethods) < 0) {
                    throw "Unknown method: " + option;
                }
                value = data[option](args[1]);
            } else {

                var timeReady = setInterval(function () {
                    if (!!$.fn.addEvent) {
                        clearInterval(timeReady);
                        data.init();
                    }
                }, 100);

                if (args[1]) {
                    value = data[args[1]].apply(data, [].slice.call(args, 2));
                }
            }
        });

        return value || this;
    };
    $.fn.ContenedorCambiarAhora.defaults = {}
    $('#ContenedorCambiarAhora').ContenedorCambiarAhora();
})(jQuery);
