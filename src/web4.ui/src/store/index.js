import { createStore } from 'vuex'
import httpclient from '@/api/httpclient'

export default createStore({
  strict: true,
  state: {
    evenements: [],
    villes: [],
    categories: [],
    pageIndex: 1,
    pageCount: 10,
    filtre: "",
    evenement: {},
    statistiques: []
  },
  getters: {
  },
  mutations: {
    getEvenementsApi(state, data){
      state.evenements = data
    },
    getVillesApi(state, data){
      state.villes = data
    },
    getCategoriesApi(state, data){
      state.categories = data
    },
    getEvenementApi(state, evenement){
      state.evenement = evenement
    },
    getStatistiqueApi(state, data){
      state.statistiques = data
    },
    deleteEvenement(state, index){
      state.evenements.splice(index, 1)
    }
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
        return Promise.reject(error)
      }) 
    },
    async filtrage(context, value){
      return await httpclient.get('Evenements', {params: {filtre: value, pageIndex: this.state.pageIndex, pageCount: this.state.pageCount}})
      .then(reponse => {
        context.commit('getEvenementsApi', reponse.data)
        return reponse
      })
      .catch(error => {
        console.log(error)
        return Promise.reject(error)
      }) 
    },
    async getVillesApi(context){
      return await httpclient.get('Villes')
      .then(reponse => {
        context.commit('getVillesApi', reponse.data)
        return reponse
      })
      .catch(error => {
        console.log(error)
        return Promise.reject(error)
      }) 
    },
    async getCategoriesApi(context){
      return await httpclient.get('Categorie')
      .then(reponse => {
        context.commit('getCategoriesApi', reponse.data)
        return reponse
      })
      .catch(error => {
        console.log(error)
        return Promise.reject(error)
      }) 
    },
    async getEvenementApi(context, id){
      return await httpclient.get(`Evenements/${id}`)
      .then(reponse => {
        context.commit('getEvenementApi', reponse.data)
      })
      .catch(error => {
        console.log(error)
        return Promise.reject(error)
      })
      
    },
    async createParticipation(context, participation){
      return httpclient.post('Participation', participation)
      .then((reponse => {
        this.dispatch('getEvenementsApi')
        return reponse.data
      }))
      .catch(error => {
        console.log(error)
        return Promise.reject(error)
      })
    },
    async getStatistiqueApi(context) {
      return await httpclient.get(`../GetEvenementsProfitables`)
        .then(reponse => {
          context.commit('getStatistiqueApi', reponse.data)
          return reponse})
        .catch(error => {
          console.log(error)
          return Promise.reject(error)
        })
    },
    async deleteEvenement(context, index){
      let id = this.state.evenements[index].id
      httpclient.delete(`Evenements/${id}`)
      .then(() => {
        context.commit('deleteEvenement', index)
        this.dispatch('getEvenementsApi')
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
