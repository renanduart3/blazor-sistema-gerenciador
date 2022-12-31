/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        '!**/{bin,obj,node_modules}/**',
        '**/*.{razor,html}',
    ],
    theme: {
        extend: {
            colors: {
                clifford: '#da373d',
            }
        },
    },
    plugins: [],
}
