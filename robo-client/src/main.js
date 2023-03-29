import Vue from 'vue'
import App from './App.vue'
import vuetify from './plugins/vuetify'

Vue.config.productionTip = false
fetch(process.env.BASE_URL + "config.json")
  .then((response) => response.json())
  .then((config) => {
       Vue.prototype.$config = config
new Vue({
  vuetify,
  render: h => h(App)
}).$mount('#app')})
