module.exports = {
    content: [
        './**/*.{razor,razor.css,html,cshtml}',
        '../bjorkvalle.UI/**/*.{razor,razor.css,html,cshtml}'
    ],
    theme: {
        container: {
            center: true,
        },
        extend: {
            keyframes: {
                'fade-in': {
                    '0%': {
                        opacity: '0',
                    },
                    '100%': {
                        opacity: '1',
                    },
                },
                'fade-out': {
                    '0%': {
                        opacity: '1',
                    },
                    '100%': {
                        opacity: '0',
                    },
                }
            },
            animation: {
                'fade-in': 'fade-in 0.5s ease-out',
                'fade-out': 'fade-out 0.5s ease-out'
            }
        },
    },
    plugins: [require("daisyui")],
}
