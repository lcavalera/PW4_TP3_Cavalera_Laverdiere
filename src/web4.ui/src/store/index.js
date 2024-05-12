import { createStore } from 'vuex'
import httpclient from '@/api/httpclient'

export default createStore({
  strict: true,
  state: {
    evenements: []
  },
  getters: {
  },
  mutations: {
  },
  actions: {
    async getEvenementsApi(context){
      return await httpclient.get('Evenements')
      .then(reponse => {
        context.commit('getTodosApi', reponse.data)
        return reponse
      })
      .catch(error => {
        console.log(error)
        return Promise.reject(error)
      }) 
    },
  },
  modules: {
  }
})
