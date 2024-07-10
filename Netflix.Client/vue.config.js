// const url = "http://localhost:5226";
const url = "https://project-vue.tobecon.co.kr";

module.exports = {
    publicPath: process.env.NODE_ENV === "production" ? "/app/" : "/",
    // 빌드 시 다음 오류가 발생하면 parallel: false로 설정함
    // "Cannot read property 'createChildCompiler' of undefined"
    // parallel: false,
    assetsDir: "assets",
    devServer: {
        proxy: {
            "/api": {
                target: url
            },
            "^/assets": {
                pathRewrite: { "^/assets": "" },
                target: `${url}`,
                ws: false
            }
        },
        port: 3000,
        https: false,
    },
    configureWebpack: {
        devtool: "source-map",
    }
};