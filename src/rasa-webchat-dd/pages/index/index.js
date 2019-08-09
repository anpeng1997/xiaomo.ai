import { add } from '../../store/actions/home'
const app = getApp()

Page({
    data: {
        ...app.store.getState().home
    },
    onLoad(query) {
        // 页面加载
        console.info(`Page onLoad with query: ${JSON.stringify(query)}`);
        const that =this;
        this.unSubscribe = app.store.subscribe(() => {
            let home = app.store.getState().home
            console.log('store.subscribe person:', home)
            //这里要做个判断，当收到的状态与页面上已有的状态不一致时才去操作页面，可能会频繁收到订阅消息，要小心操作
            that.setData({...home})
        })
    },
    onShareAppMessage() {
        // 返回自定义分享信息
        return {
            title: 'My App',
            desc: 'My App description',
            path: 'pages/index/index',
        };
    },
    add(event) {
        app.store.dispatch(add())
    }
});
