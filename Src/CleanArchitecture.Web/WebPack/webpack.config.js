const path = require('path');
const { CleanWebpackPlugin } = require('clean-webpack-plugin');
const MiniCssExtractPlugin = require("mini-css-extract-plugin");

module.exports = {
    entry: {
        site: './src/js/site.js'
    },
    output: {
        filename: '[name].bundle.js',
        path: path.resolve(__dirname, '..', 'wwwroot', 'dist')
    },
devtool: 'source-map',
    mode: 'development',
    optimization: {
        splitChunks: {
            chunks: 'async',
            minSize: 20000,
            minRemainingSize: 0,
            minChunks: 1,
            maxAsyncRequests: 30,
            maxInitialRequests: 30,
            enforceSizeThreshold: 50000,
            cacheGroups: {
                defaultVendors: {
                    test: /[\\/]node_modules[\\/]/,
                    priority: -10,
                    reuseExistingChunk: true,
                },
            },
        }, //end split chunks
    }, //end optimization

    module: {

        rules: [
            {
                test: /\.css$/,
                use: [{ loader: MiniCssExtractPlugin.loader }, 'css-loader'],
            },
            {
                test: /\.(eot|woff(2)?|ttf|otf|svg)$/i,
                type: 'asset'
            },
        ],
    },

    //plugins configuration here
    plugins: [
        new CleanWebpackPlugin(),
        new MiniCssExtractPlugin({
 filename: "[name].bundle.css"
                })
        ]
};