'use strict'

const path = require('path');
const CleanWebpackPlugin = require('clean-webpack-plugin');

module.exports = {
    // entry: ['babel-polyfill', './index.js'],
    entry: './index.js',
    output: {
        path: path.join(__dirname, '/lib'),
        filename: 'index.js',
        library: 'WebChat',
        libraryTarget: 'umd'
    },
    resolve: {
        extensions: ['.js', '.jsx']
    },
    mode: 'production',
    module: {
        rules: [
            {
                test: /\.(js|jsx)$/,
                exclude: /node_modules/,
                loader: 'babel-loader'
            },
            {
                test: /\.less$/,
                use: [
                    { loader: 'style-loader' },
                    { loader: 'css-loader' },
                    { loader: 'autoprefixer-loader' },
                    {
                        loader: 'less-loader',
                        options: {
                            includePaths: [path.resolve(__dirname, 'src/less/')]
                        }
                    }
                ]
            },
            {
                test: /\.(jpg|png|gif|svg)$/,
                use: {
                    loader: 'url-loader'
                }
            }
        ]
    },
    plugins: [new CleanWebpackPlugin(['lib'])]
};