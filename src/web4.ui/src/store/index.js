import { createStore } from 'vuex'
import httpclient from '@/api/httpclient'

export default createStore({
  strict: true,
  state: {
    evenements: [],
    pageIndex: 1,
    pageCount: 10,
    filtre: ""
  },
  getters: {
  },
  mutations: {
    getEvenementsApi(state, data){
      state.evenements = data
  },
  },
  actions: {
    async getEvenementsApi(context){
      return await httpclient.get('Evenements')
      .then(reponse => {
        context.commit('getEvenementsApi', reponse.data)
        return reponse
      })
      .catch(error => {
        console.log(error)
        // return Promise.reject(error)
      }) 
    },
    async filtrage(context, value){
      return await httpclient.get('Evenements', {params: {filtre: value}})
      .then(reponse => {
        context.commit('getEvenementsApi', reponse.data)
        return reponse
      })
      .catch(error => {
        console.log(error)
        return Promise.reject(error)
      }) 
    }
  },
  modules: {
  }
})
