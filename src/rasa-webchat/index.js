import React from 'react';
import ReactDOM from 'react-dom';
import ConnectedWidget from './src';

const plugin = {
    init: (args) => {
        ReactDOM.render(
            <ConnectedWidget />, document.querySelector(args.selector)
        );
    }
};

export {
    plugin as default,
}